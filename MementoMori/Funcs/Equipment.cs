using MementoMori.Ortega.Share.Data.ApiInterface.Equipment;

namespace MementoMori.Funcs;

public partial class MementoMoriFuncs
{
    public async Task AutoEquipmentTraning()
    {
        await ExecuteQuickAction(async (log, token) =>
        {
            var equipmentGuids = TrainingEquipmentGuid.Split(',').Select(g => g.Trim()).Where(g => !string.IsNullOrEmpty(g)).ToList();
            foreach (var guid in equipmentGuids)
            {
                var totalCount = 0;
                while (!token.IsCancellationRequested)
                {
                    // await UserGetUserData();
                    var equipment = UserSyncData.UserEquipmentDtoInfos.First(d => d.Guid == guid);
                    var equipmentMb = EquipmentTable.GetById(equipment.EquipmentId);
                    var currentParameter = equipment.GetAdditionalParameter(EquipmentTrainingTargetType);
                    var m =
                        $"{TextResourceTable.Get("[CommonForgedLabel]")} {totalCount}, {TextResourceTable.Get(EquipmentTrainingTargetType)} {currentParameter} ({(double) currentParameter / equipmentMb.AdditionalParameterTotal:P})";
                    log(m);
                    var targetValue = equipmentMb.AdditionalParameterTotal * EquipmentTrainingTargetPercent;
                    bool isReached = false;
                    if (EquipmentTrainingTargetType == BaseParameterType.Health && equipment.AdditionalParameterHealth >= targetValue) isReached = true;
                    else if (EquipmentTrainingTargetType == BaseParameterType.Energy && equipment.AdditionalParameterEnergy >= targetValue) isReached = true;
                    else if (EquipmentTrainingTargetType == BaseParameterType.Intelligence && equipment.AdditionalParameterIntelligence >= targetValue) isReached = true;
                    else if (EquipmentTrainingTargetType == BaseParameterType.Muscle && equipment.AdditionalParameterMuscle >= targetValue) isReached = true;
                    if (isReached) break;

                    var response = await GetResponse<TrainingRequest, TrainingResponse>(new TrainingRequest {EquipmentGuid = guid, ParameterLockedList = new List<BaseParameterType>()});
                    totalCount++;
                    await Task.Delay(GameConfig.AutoRequestDelay, token);
                }
            }
            return;
        });
    }

    public async Task ReinforcementEquipmentOneTime()
    {
        await ExecuteQuickAction(async (log, token) =>
        {
            var equipmentDtoInfo = UserSyncData.UserEquipmentDtoInfos.OrderBy(d => d.ReinforcementLv)
                .FirstOrDefault(d => !string.IsNullOrEmpty(d.CharacterGuid) && EquipmentTable.GetById(d.EquipmentId).EquipmentLv > d.ReinforcementLv);
            if (equipmentDtoInfo != null)
            {
                var response = await GetResponse<ReinforcementRequest, ReinforcementResponse>(new ReinforcementRequest {EquipmentGuid = equipmentDtoInfo.Guid, NumberOfTimes = 1});
                log($"{TextResourceTable.Get("[CommonReinforceLabel]")} {ResourceStrings.Finished}");
            }
        });
    }
}