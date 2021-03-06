![image](https://github.com/sextance/TDemo/blob/main/Preview.png)
# 游戏简介

《初光》是一款注重PVP即时对战的塔防游戏。游戏的定位到了漂泊在虚空中的位面，双方玩家作为同一地图、不同位面的开拓者，可以利用初光建造三种不同的塔，抵御来自虚空的混乱信息体。同时，玩家可以通过对自己的塔进行转化、固化和自毁等策略，在相反位面（即对手的地图）上对应的位置产生混乱信息体，以摧毁敌人的防线。
演示视频：https://www.bilibili.com/video/BV1bv411t7t1

# 背景介绍

破裂的平行空间碎片（对称位面）漂泊在虚空之间。两个位面是竞争关系，一个位面的秩序是另一个位面中混沌的化身，开拓者在虚空漫游时少有的娱乐方式就是在对称位面进行秩序和混沌的对抗，为了等待另一个开拓者的到来，他们甚至会等上几百几千年--虽然他们本来就没有所谓的时间观念。

虚空中的事物分为混沌和秩序两大类，所有单位都用信息量表现其存在状态（生命值）。

开拓者（玩家）的初光能维持空间的稳定，他需要用初光单位来稳固空间抵挡混沌信息体的侵袭，直到另一位面被改造成混沌位面时当前位面才能不再产生混沌信息体，如果区域地面上的初光单位被清空，当前区域就会被混沌摧毁，一片黑暗。

# 玩法介绍

### 塔

* 脉冲Ⅰ型
  * 攻击塔
  * 具有攻击能力，可以攻击附近1格的敌方单位
  * 需要附近有源光塔进行供能才能进行攻击
* 力场Ⅰ型
  * 防御塔
  * 具有较高的生命值，并且可以嘲讽附近1格的敌方单位，保护其他脆弱的我方单位
  * 需要附近有源光塔进行供能才能进行嘲讽
* 源光Ⅰ型
  * 生产塔
  * 具有持续生产初光（费用）的能力，供给建造/固化/自毁等操作
  * 为附近1格内的脉冲、立场塔供能
* 脉冲Ⅱ型
  * 固化后的攻击塔，可以脱离源光塔供能范围运作
  * 具有更强的攻击能力，可以攻击附近2格的敌方单位
  * 可以在平行位面的同一位置持续生成狂躁信息体
* 力场Ⅱ型
  * 固化后的防御塔，可以脱离源光塔供能范围运作
  * 具有更高的生命值，可以嘲讽附近2格的敌方单位，保护其他脆弱的我方单位
  * 可以在平行位面的同一位置持续生成沉稳信息体
* 源光Ⅱ型
  * 固化后的生产塔
  * 具有更强的持续生产初光（费用）能力，供给建造/固化/自毁等操作
  * 为附近约3格内的脉冲、立场塔供能
  * 可以在平行位面的同一位置持续生成大量混沌信息体

### 怪物

* 混沌信息体
  * 小怪
  * 攻击力和生命值都较低
* 狂躁信息体
  * 精英怪
  * 攻击力极高，生命值较高
* 沉稳信息体
  * 精英怪
  * 生命值极高，具有嘲讽能力

### 操作

* 建造
  * 可以在源光塔附近的地块建造Ⅰ型塔
  * 三种Ⅰ型塔的初光（费用：5）相同
  * 建造时间2秒
* 转化
  * 可以随时将Ⅰ型塔转化为其他类型的Ⅰ型塔
  * 同一塔的转化操作有冷却时间
  * 固化后的塔无法转化
* 固化
  * 若相邻三个地块（三角形）内有同类型的Ⅰ型塔，可以消耗费用对塔进行固化
  * 固化后，三个Ⅰ型塔融合成为一个Ⅱ型塔，占据三格地块，具有更强的能力
  * 固化后的塔会在另一名玩家的相同位置的地块持续生产怪物，以摧毁敌方的塔
* 自毁
  * 可以随时消耗费用让塔自毁，并在另一名玩家的相同位置的地块一次性生成塔对应类型的大量怪物
* 扫描
  * 可以随时选择扫描另一玩家的地图，观察其塔的布局
  * 在扫描过程的固定4s内，无法在自己的地图上做任何操作



