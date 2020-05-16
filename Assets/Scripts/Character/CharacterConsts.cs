using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 卡牌种类枚举常数
/// </summary>
public class CharacterConsts {


    /// <summary>
    /// 卡牌类型
    /// </summary>
    public enum CharacterType
    {
        Role = 1,        //角色卡
        Function = 2,    //功能卡
        Event = 3        //事件卡
    }

    /// <summary>
    /// 敌我分类
    /// </summary>
    public enum Belong
    {
        ally = 1,       //己方
        enemy =2        //敌方
    }

    /// <summary>
    /// 己方英雄
    /// </summary>
    public enum AllyType
    {
        Warrior = 1,
        Archer = 2,
        Druggist = 3, //药剂师
        Healer = 4, //医药师
        Alchemist = 5
    }

    /// <summary>
    /// 敌方种类
    /// </summary>
    public enum EnemyType
    {
        Infected = 1,
        Mouse = 2,
        Bat = 3,
        Dread = 4,
        Poisoner = 5
    }
}
