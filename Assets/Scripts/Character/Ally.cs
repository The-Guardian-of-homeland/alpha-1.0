using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 我方英雄类  继承角色基类
/// </summary>
public class Ally : Character   
{
    public int cost;  //召唤所需金币
    public int skill; //技能类别 群体攻击 单体攻击 治疗 制造金币
    public int mp;    //魔法值
    public int totalmp; //当前魔法值
    public new GameObject[] gameObject;  //游戏对象数组


    /// <summary>
    /// 初始化
    /// </summary>
    public override void Init()
    {
        hp = 100;
        mp = 100;
        level = 1;
        totalhp = hp;
        totalmp = mp;
        StartCoroutine(Attack(direction,mp));//协同程序 初始化后延迟开始动作
    }

    /// <summary>
    /// 英雄功能分类函数
    /// </summary>
    public void Work(int skill,int damage,int hp,int mp,int money,int direction,Transform position) 
    {
        switch (skill)
        {
            case 1://范围攻击
                Attack(direction,mp);
                break;
            case 2://单一攻击
                Attack(1,mp);
                break;
            case 3://治疗血量
                Cure(1,hp, mp);
                break;
            case 4://治疗蓝量
                Cure(2,hp, mp);
                break;
            case 5://制造金币
                Earn(mp, money);
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// 攻击
    /// </summary>
    IEnumerator Attack(float direction,int mp) 
    {
        yield return new WaitForSeconds(2.0f); //延迟2秒后开始
        if (totalmp > mp)
        {
            totalmp -= mp;
            if (totalmp < mp)
            {
                
            }
        }
        
    }

    /// <summary>
    /// 治疗
    /// </summary>
    public void Cure(int i,int hp,int mp) 
    {
        
        if (i == 1) //治疗血量
        {
            if (totalmp > mp)
            {
                totalmp -= mp;
                totalhp += hp;
                if (totalmp < mp)
                {
                    return;
                }
            }
        }
        if (i == 2) //治疗蓝量
        {
            if (totalmp > mp)
            {
                totalmp -= mp;
                totalmp += mp;
                if (totalmp < mp)
                {
                    return;
                }
            }
        }
    }

    /// <summary>
    /// 制造金币
    /// </summary>
    public void Earn(int mp,int m) 
    {
        if (totalmp > mp)
        {
            totalmp -= mp;
            money += m;
            if (totalmp < mp)
            {
                return;
            }
        }
    }
    /// <summary>
    /// 构造函数
    /// </summary>
    public Ally(string job, int totalhp, Transform position, Transform target, float direction, CharacterConsts.Belong belong,int damage,int skill,int cost,int mp,int totalmp) : base(job, totalhp, position, target, direction, belong, damage)
    {
        this.job = job;
        this.totalhp = totalhp; 
        this.position = position;
        this.target = target;
        this.direction = direction;
        this.cost = cost;
        this.mp = mp;
        this.skill = skill;
        this.totalmp = totalmp;
        this.damage = damage;
    }
}
