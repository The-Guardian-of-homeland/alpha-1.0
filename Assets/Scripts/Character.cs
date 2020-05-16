using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 角色基类
/// </summary>
public class Character : MonoBehaviour
{
    public string job;            //职业描述
    public float direction;       //攻击范围
    public int damage;            //伤害值
    public int hp;                //生命
    public int totalhp;           //当前生命
    public int level;             //等级
    public Image image;           //图片信息
    public Transform position;    //Vector3 坐标
    public Transform target;      //攻击目标坐标
    public int money;             //金钱
    private CharacterConsts.Belong belong;    //敌我分类

    /// <summary>
    /// 初始化数值定义
    /// </summary>
    public virtual void Init()
    {
        hp = 100;
        totalhp = hp;
        level = 1;
    }

    /// <summary>
    /// 受到伤害
    /// </summary>
    public void Damage(int damage)  //传递伤害值参数
    {
        if (totalhp > damage) //当前血量大于受伤血量,正常扣血
        {
            totalhp -= damage;
            if (totalhp < damage)
            {
                totalhp = 0;
                Die();      //死亡
            }
        }
    }

    /// <summary>
    /// 死亡函数
    /// </summary>
    public void Die()
    {
        totalhp = 0;
        Destroyself();  //移除战场
    }

    public void Destroyself()
    {
        Destroy(gameObject);
    }
    /// <summary>
    /// 构造函数
    /// </summary>
    public Character(string job, int totalhp, Transform position, Transform target, float direction, CharacterConsts.Belong belong,int damage)
    {
        this.job = job;
        this.totalhp = totalhp;
        this.position = position;
        this.target = target;
        this.direction = direction;
        this.belong = belong;
        this.damage = damage;   
    }

   
}













