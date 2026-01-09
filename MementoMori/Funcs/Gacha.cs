using MementoMori.Exceptions;
using MementoMori.Ortega.Custom;
using MementoMori.Ortega.Share.Data.ApiInterface.Gacha;
using MementoMori.Ortega.Share.Data.DtoInfo;
using MementoMori.Ortega.Share.Data.Gacha;

namespace MementoMori.Funcs;

public partial class MementoMoriFuncs
{
    public static readonly Dictionary<int, string> ItemTypeNames = new Dictionary<int, string>
    {
        { 3,  "金幣" },
        { 16, "聖遺物召喚券" },
        { 23, "友情點數" }
    };

    public async Task FreeGacha()
    {
        await ExecuteQuickAction(async (log, token) =>
        {
            HashSet<long> ignoredButtonId = [];
            var consumeItems = GameConfig.GachaConfig.AutoGachaConsumeUserItems;
            foreach (var consume in consumeItems)
            {
                if (ItemTypeNames.TryGetValue((int) consume.ItemType, out string typeName))
                {
                    log($"使用的消耗品: {typeName}");
                }
            }
            while (await DoFreeGacha())
            {
            }

            log(ResourceStrings.NoAvailableGacha);

            async Task<bool> DoFreeGacha()
            {
                var gachaListResponse = await GetResponse<GetListRequest, GetListResponse>(new GetListRequest());
                foreach (var gachaCaseInfo in gachaListResponse.GachaCaseInfoList)
                {
                    var gachaCaseMb = GachaCaseTable.GetById(gachaCaseInfo.GachaCaseId);
                    var userItems = UserSyncData.UserItemDtoInfo.ToList();
                    var buttonInfo = gachaCaseInfo.GachaButtonInfoList.OrderByDescending(d => d.LotteryCount).FirstOrDefault(d => GameConfig.GachaConfig.AutoGachaConsumeUserItems.Exists(consumeUserItem => CheckCount(d, userItems, consumeUserItem.ItemType, consumeUserItem.ItemId)));
                    if (buttonInfo == null) continue;
                    if (ignoredButtonId.Contains(buttonInfo.GachaButtonId)) continue;

                    log($"正在使用消耗品抽: {gachaCaseMb.Memo}");
                    var itemMb = ItemTable.GetByItemTypeAndItemId(buttonInfo.ConsumeUserItem.ItemType, buttonInfo.ConsumeUserItem.ItemId);
                    var name = TextResourceTable.Get(itemMb.NameKey);
                    log(string.Format(ResourceStrings.GachaExecInfo, gachaCaseMb.Memo, buttonInfo.LotteryCount, name, buttonInfo.ConsumeUserItem.ItemCount));
                    try
                    {
                        var response = await GetResponse<DrawRequest, DrawResponse>(new DrawRequest {GachaButtonId = buttonInfo.GachaButtonId});
                        response.GachaRewardItemList.PrintUserItems(log);
                        response.BonusRewardItemList.PrintUserItems(log);
                    }
                    catch (ApiErrorException e) when (e.ErrorCode == ErrorCode.GachaHaveMaxCharacter)
                    {
                        ignoredButtonId.Add(buttonInfo.GachaButtonId);
                    }

                    return true;
                }

                return false;
            }

            bool CheckCount(GachaButtonInfo buttonInfo, List<UserItemDtoInfo> userItems, ItemType itemType, long itemId = 1)
            {
                if (itemId == 0) itemId = 1;
                if (buttonInfo.ConsumeUserItem == null ||
                    buttonInfo.ConsumeUserItem.ItemCount == 0)
                    return true;

                if (buttonInfo.ConsumeUserItem.ItemType != itemType ||
                    buttonInfo.ConsumeUserItem.ItemId != itemId)
                    return false;

                var count = userItems.GetCount(itemType, itemId);
                return buttonInfo.ConsumeUserItem.ItemCount <= count;
            }
        });
    }

    public async Task AutoSetGachaRelic()
    {
        await ExecuteQuickAction(async (log, token) =>
        {
            var targetRelicType = PlayerOption.GachaConfig.TargetRelicType;
            if (targetRelicType == GachaRelicType.None) return;

            var listResponse = await GetResponse<GetListRequest, GetListResponse>(new GetListRequest());
            if (!listResponse.IsFreeChangeRelicGacha) return;

            var gachaCaseInfo = listResponse.GachaCaseInfoList.Find(d => d.GachaGroupType == GachaGroupType.HolyAngel);
            if (gachaCaseInfo == null) return;

            if (gachaCaseInfo.GachaRelicType == targetRelicType) return;
            if (gachaCaseInfo.GachaBonusDrawCount > 0) return;

            await GetResponse<ChangeGachaRelicRequest, ChangeGachaRelicResponse>(new ChangeGachaRelicRequest {GachaRelicType = targetRelicType});

            log($"{TextResourceTable.Get("[GachaRelicChangeTitle]")} {targetRelicType.GetName()} {ResourceStrings.Success}");
        });
    }

    public async Task DrawGachaRelic()
    {
        await ExecuteQuickAction(async (log, token) =>
        {
            if (!PlayerOption.GachaConfig.AutoGachaRelic)
            {
                log("未設定自動補抽聖遺物");
                return;
            }
            var listResponse = await GetResponse<GetListRequest, GetListResponse>(new GetListRequest());
            var gachaCaseInfo = listResponse.GachaCaseInfoList.Find(d => d.GachaGroupType == GachaGroupType.HolyAngel);
            if (gachaCaseInfo == null) return;

            var gachaCaseMb = GachaCaseTable.GetById(gachaCaseInfo.GachaCaseId);
            log($"正在補抽聖遺物: {gachaCaseMb.Memo}");

            if (gachaCaseInfo.GachaBonusDrawCount != 7) 
            {
                log("抽取次數已超過或未滿7次!請檢查次數!");
                return;
            }

            int totalDrawCount = gachaCaseInfo.GachaBonusDrawCount;

            while (totalDrawCount < 10)
            {
                var currency = UserSyncData.GetUserItemCount(ItemType.CurrencyFree, isAnyCurrency: true);
                var gachaButtonInfo = gachaCaseInfo.GachaButtonInfoList.Find(d => d.ConsumeUserItem.IsCurrency() && d.ConsumeUserItem.ItemCount == 300);
                if (gachaButtonInfo == null) break;
                if (currency < 300)
                    {
                        log("鑽石不足，停止抽卡");
                        break;
                    }
                var drawResponse = await GetResponse<DrawRequest, DrawResponse>(new DrawRequest {GachaButtonId = gachaButtonInfo.GachaButtonId});
                drawResponse.GachaRewardItemList.PrintUserItems(log);
                drawResponse.BonusRewardItemList.PrintUserItems(log);
                totalDrawCount += 1;
            }
        });
    }
}