[ [Zh](README.md) | [En](readme.en.md) ]

# MementoMori 遊戲小助手

[![GitHub Workflow Status (with event)](https://img.shields.io/github/actions/workflow/status/moonheart/mementomori-helper/publish-dev.yml)](https://github.com/moonheart/mementomori-helper/actions/workflows/publish-dev.yml)
[![GitHub Release Date - Published_At](https://img.shields.io/github/release-date/moonheart/mementomori-helper)](https://github.com/moonheart/mementomori-helper/releases)
[![GitHub release (with filter)](https://img.shields.io/github/v/release/moonheart/mementomori-helper)](https://github.com/moonheart/mementomori-helper/releases)
[![GitHub all releases](https://img.shields.io/github/downloads/moonheart/mementomori-helper/total)](https://github.com/moonheart/mementomori-helper/releases)
[![Docker Pulls](https://img.shields.io/docker/pulls/moonheartmoon/mementomori-webui)](https://hub.docker.com/r/moonheartmoon/mementomori-webui/)

[Mem W8  ₊貓淺町⁺⁎· Discord](https://discord.gg/hqARjHJEAr)

---

## **免責聲明**

使用本輔助工具的用戶（以下簡稱「用戶」）請注意以下幾點：

1. 用途限制：

    本輔助工具僅供個人娛樂和教育目的使用。使用本工具可能違反特定遊戲或應用程式的使用政策，請自行承擔風險。

2. 責任聲明：

    開發者（以下簡稱「我們」）不對用戶在遊戲中使用本工具所產生的任何後果負任何法律或道德責任，用戶應自行承擔使用工具可能帶來的風險。

3. 風險提示：

    用戶需明白遊戲或應用程式的開發者可能會採取措施來檢測並阻止輔助工具的使用，這可能導致用戶的帳戶被封鎖（封號）或受到其他制裁。

4. 合法要求：

    使用本輔助工具可能違反適用法律，用戶需確保自己的使用遵守所有適用法律和法規。

5. 保留權利：

    我們保留隨時更改或停止本輔助工具的權利，無需提前通知。

通過下載、安裝和使用本輔助工具，用戶表明已詳細閱讀並理解此免責聲明，並同意自行承擔使用本工具所帶來的一切風險。如不同意本聲明的任何部分，請停止使用本輔助工具。

---

## 預覽
<table>
<tbody>
<tr><td> 

![](images/intro1.png) </td><td>![](images/intro2.png)</td></tr>
<tr><td>

![](images/intro3.png)</td><td>![](images/intro4.png)</td></tr>
<tr><td>

![](images/intro5.png)</td><td>![](images/intro6.png)</td></tr>
<tr><td>

![](images/intro7.png)</td><td>![](images/intro8.png)</td></tr>
</tbody>
</table>

---

## 功能一覽

<!-- prettier-ignore -->
<table>
  <tbody>
  <tr >
      <td>

- [x] 多帳號支援
    - [x] 帳號引繼碼直接登入
- [ ] 主頁
    - [x] 玩家登入
    - [x] 領取每日登入獎勵
    - [x] 領取每日 VIP 獎勵
    - [x] 一鍵發送/接收友情點數
    - [x] 一鍵領取禮物箱
    - [x] 一鍵領取任務獎勵
    - [x] 一鍵領取徽章獎勵
    - [x] 一鍵使用固定物品
    - [x] 自動領取月卡獎勵
- [ ] 商店
    - [x] 普通物品購買
    - [x] 符石購買
    - [x] 自動購買
- [ ] 角色
	- [x] 角色清單
	- [x] 角色屬性
	- [x] 角色裝備
	- [ ] 升級
	- [ ] 突破
    - [ ] 隊伍編成

</td>
<td>

- [ ] 物品箱
	- [x] 自動使用物品
	- [x] 自動精煉魔裝並繼承到D級裝備
	- [x] 自動繼承神裝到D級裝備
	- [x] 裝備自動打魔
	- [ ] 手動使用物品
- [ ] 冒險
    - [x] 領取自動掛機獎勵
    - [x] 一鍵高速戰鬥
    - [x] 一件掃蕩首領
    - [x] 自動通關
      - [x] 抵達指定關卡後停止
- [ ] 試煉
    - [x] 一鍵掃蕩無窮之塔
    - [x] 無窮之塔自動通關
      - [x] 抵達指定關卡後停止
    - [x] 一鍵挑戰幻影神殿
      - [x] 跟隨模式
      - [ ] 建房模式
      - [x] 設定獎勵權重
    - [x] 一鍵挑戰古競技場
    - [x] 一鍵領取祈願之泉
    - [x] 一鍵遠征祈願之泉
      - [x] 設定獎勵物品派遣任務
    - [x] 一鍵挑戰時空洞窟
      - [x] 設定自動購買指定商品
      - [x] 優先選擇寶箱路徑
      - [x] 自動使用恢復道具
</td>
<td>

- [ ] 抽卡
    - [x] 每日免費/金幣抽卡
    - [x] 卡池清單
    - [x] 手動抽卡
- [ ] 公會
    - [x] 簽到
    - [x] 自動掃蕩討伐
    - [x] 自動開啟討伐
    - [x] 領取公會戰獎勵
- [ ] 其他
    - [x] 通關時同時進行其他任務 
    - [x] 通關速度限制 

</td>
</tr>

  </tbody>
</table>

---

## 如何使用

### 方法1 Docker

1. 請先下載[Docker](https://www.docker.com/products/docker-desktop/)
2. 下載本遊戲小助手[完整資料包](https://github.com/Sola-AIGithub/MementomoriHelper/archive/refs/heads/main.zip)並解壓縮
3. 前往解壓蘇的檔案夾，執行[指令檔](docker-compose.bat)
4. 首次建立需要較多時間下載資料(約3分鐘，視網路速度而定)
5. 前往遊戲小助手[網址](http://127.0.0.1:5290/)
   
### 方法2 Windows

由於Sola改版程式，暫時未發布Windows exe版本。

### 方法3 Android

由於Sola改版程式，暫時未發布Android apk版本。

### 帳號設定

啟動小助手後，進入設定頁面，新增帳號並輸入自訂帳號名稱、引繼ID與引繼密碼

---

## 自動執行排程

小助手會在特定時間執行遊戲操作，若需更改時間請先研究[Cron表達式(Quartz格式)](https://www.freeformatter.com/cron-expression-generator-quartz.html)

### 每日任務 (伺服器時間 4:10)

- 領取每日登入獎勵
- 領取每日 VIP 獎勵
- 領取自動戰鬥獎勵
- 領取、發送友情點
- 領取禮物箱
- 強化一次裝備 (自動選擇目前有角色裝備中等級最低的裝備，用於完成每日任務)
- 主線掃蕩 3 次
- 無窮之塔掃蕩 3 次
- 免費高速戰鬥 (免費一次，月卡一次)
- 公會簽到
- 公會討伐戰
- 領取祈願之泉獎勵
- 自動派遣祈願之前
- 自動挑戰時空洞窟
- 領取每日、每週任務獎勵
- 使用固定道具
- 使用道具抽卡
- 自動進階角色 (R > R+ 、 SR > SR+)

### 獎勵定時領取 (伺服器時間 0:30、4:30、8:30、12:30、16:30、20:30)

- 領取每日登入獎勵
- 領取自動戰鬥獎勵
- 領取與派遣祈願之泉
- 公會討伐戰
- 領取友情點數
- 領取任務獎勵
- 領取公會戰獎勵
- 自動抽卡
- 使用固定物品

### 競技場 (伺服器時間 20:00)

- 古競技場 5 次 (自動選擇戰力最低的對手)
- 巔峰競技場 5 次 (自動選擇戰力最低的對手)

---

## 功能說明

### 簽到獎勵

自动领取每日签到奖励、累计签到天数奖励、限时签到奖励

### VIP 每日福利

自动领取 VIP 每日免费礼物

### 每月强化组合包

自动领取每月强化组合包

### 自动战斗报酬

自动领取自动战斗报酬

### 友情点数

自动赠送和领取友情点数

### 强化一次装备

用于完成每日任务 “進行武具強化1次”

装备选择策略：有角色装备的且等级最低的且等级未达到上限的装备

### 挑战首领 3 次

自动使用每日 3 次的免费挑战首领的次数。优先使用扫荡，如果扫荡没解锁就使用挑战。

### 无穷之塔 3 次

自动使用每日 3 次的免费挑战无穷之塔的次数。优先使用扫荡，如果扫荡没解锁就使用挑战。

### 古竞技场自动战斗 5 次

自动进行 5 次古竞技场的战斗。

对手选择策略：列表中战斗力最低的玩家

### 巅峰竞技场自动战斗 10 次

自动进行 10 次巅峰竞技场的战斗。

对手选择策略：列表中战斗力最低的玩家

### 免费高速战斗

自动使用免费的 2 小时高速战斗次数。

### 免费召唤

自动使用道具进行抽卡。

道具配置：选项 - 召唤 - 自动抽卡消耗物品

### 公会签到

自动领取每日公会签到奖励。

### 公会讨伐战

自动进行公会讨伐战的战斗。优先使用扫荡，如果扫荡没解锁就使用挑战。

### 公会讨伐战开放

自动开放光士公会讨伐战。

### 公会战部署防御

自动在公会战中的本公会据点上部署防御。

部署策略：从大据点到小据点依次部署，部署时第一次为 5 角色一队，后续为三次 3 角色一队，剩余未 1 角色一队。

角色选择策略：战斗力从高到低。

### 公会战领取奖励

自动领取公会战和跨服公会战的奖励

### 幻影神殿

自动进行幻影神殿的战斗。战斗方式为随机加入已有的房间。

#### 任务选择策略：

有活动时：选择活动道具报酬数量（首次奖励 + 固定奖励）最高的任务。
无活动时：按照选项中配置的报酬权重进行选择。

#### 报酬权重

进入 选项 - 幻影神殿 可以设置报酬权重，计算方法如下：

$$Sort=weight\times\frac{N_{start\_{current}}^{lv\_{current}}}{N_{start\_{max}}^{lv\_{max}}}$$

假如设置是这样的：

- 符石兑换券：5
- 潜能宝珠：3

有两个任务：
- 任务 A 报酬为符石兑换券x10，127级10星的任务报酬为符石兑换券x100, 计算可得 $0.5=5\times\frac{10}{100}$
- 任务 B 为潜能宝珠x30，127级10星的任务报酬为潜能宝珠x2000, 计算可得 $0.045=3\times\frac{30}{2000}$

最终会选择任务 A 进行战斗。

### 祈愿之泉全部领取

自动领取祈愿之泉的奖励。

### 祈愿之泉自动远征

自动派遣角色进行远征任务。

可以在 选项 - 祈愿之泉 中设置仅包含指定报酬的任务。

可以打开 强制派遣 以忽略此设置。

可以点击 刷新（钻石x20） 来刷新常规任务。

### 自动购买商城物品

可以自动购买商城物品。可以设置消耗的道具、购买的物品、最低折扣。

默认购买的物品可以在选项中找到，默认如下，可以点击 重置为默认 进行恢复：
- 用任意物品购买生命树之露 20%OFF
- 用金币购买任意物品 0%OFF

添加自动购买的物品请到左侧栏-商城，点击消耗道具旁边的闹钟按钮，会弹出一个自动购买的对话框，可以设置

- 要购买的物品，清空表示购买所有物品
- 商品打折幅度，0%OFF 表示不需要打折
- 消耗的物品，清空表示可以消耗任意物品
- 必须至少指定购买物品和消耗物品其中一个

### 使用固定物品

自动使用道具类型为“宝箱”且奖励类型为“固定”或者“随机”的道具，如宝箱、未鉴定符石。

### 批次进化

自动将 R 卡合成为 R+，将 SR 卡合成为 SR+。

### 回忆

自动阅读所有未阅读的角色回忆，可以获取钻石。

### 任务-全部领取

领取完成任务的奖章。

### 任务-奖章奖励

领取每日任务和每周任务的奖章奖励。

### 角色

从左侧边栏可以进入到角色页面。在这里可以浏览所有角色的基础信息和装备信息。

### 储物箱

从左侧边栏可以进入到储物箱页面。在这里可以浏览所有的道具和道具的信息。

### 商城

从左侧边栏可以进入到商城页面。这里和游戏中的商城是一样的，可以购买道具或符石，可以设置自动购买道具。

### 召唤

从左侧边栏可以进入到召唤页面。这里和游戏中的召唤是一样的，可以进行抽卡，可以查看抽卡详情和保底进度。

### 战斗记录

从左侧边栏可以进入到战斗记录页面。这里可以查看主线冒险和无穷之塔的战斗记录，可以直接观看战斗详细信息，也可以下载 json 文件以供分享或备份。

### 选项

从左侧边栏可以进入到选项页面。这里可以查看所有的设置，也可以查看自动任务的信息。

---

## 常見問題

### 如何多開伺服器?

本小助手預設本地電腦port號5290為入口網址，若需要增設小助手伺服器，請先下載[全新資料包](https://github.com/Sola-AIGithub/MementomoriHelper/archive/refs/heads/main.zip)並解壓縮，然後在[docker-compose.yml](docker-compose.yml)內修改以下內容:

1. container_name

2. ports

- 原來的內容

```yml

﻿version: '3'
services:
  mementomori:
    image: mementomori-helper-sola:latest
    build:
      context: .
      dockerfile: ./MementoMori.WebUI/Dockerfile
    container_name: mementomori
    restart: unless-stopped
    privileged: false
    # pull_policy: always
    ports:
      - "127.0.0.1:5290:8080"
```

- 更新後的內容

```yml

﻿version: '3'
services:
  mementomori:
    image: mementomori-helper-sola:latest
    build:
      context: .
      dockerfile: ./MementoMori.WebUI/Dockerfile
    container_name: mementomori-1
    restart: unless-stopped
    privileged: false
    # pull_policy: always
    ports:
      - "127.0.0.1:5291:8080"
```

修改完畢再執行[指令檔](docker-compose.bat)即可。

#### 注意! 新開的小助手已變成更改後的[5291 port](http://127.0.0.1:5291/)，請注意入口網址。

---

## sola修改

MementoMori\Funcs\Common.cs func AddLog 添加log時間戳

MementoMori\Funcs\Equipment.cs func AutoEquipmentTraning 修改適用全套裝備打磨語法

MementoMori\Funcs\LocalRaid.cs func AutoLocalRaid 修改預設權重

MementoMori.BlazorShared\Components\EquipmentTraining.razor 修改MudSelect下拉式選單新增all選項

MementoMori.BlazorShared\Components\Settings\LocalRaidSettings.razor 修改預設顯示權重

MementoMori.WebUI\appsettings.json 修改預設權重

MementoMori\Jobs\TimeZoneAwareJobRegister.cs func NormalizeCron 修改定時任務去秒機制
