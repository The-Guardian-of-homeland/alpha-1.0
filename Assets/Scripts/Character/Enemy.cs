using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 敌人雄类  继承角色基类
/// </summary>
public class Enemy : Character {
	public float speed; //速度
	public float power; //能力
    public int golddrop; //掉落金币

    /// <summary>
    /// 初始化
    /// </summary>
    public override void Init()
    {
        hp = 100;      
        level = 1;
        totalhp = hp;
        speed = 1.0f;
        golddrop = 5;
        StartCoroutine(move(speed));//延迟函数
    }

    /// <summary>
    /// 移动
    /// </summary>
    IEnumerator move(float speed) 
    {
        yield return new WaitForSeconds(1.5f);
        if (target != null)
        {
        }
    }

    /// <summary>
    /// 金币掉落
    /// </summary>
    public void dropgold(int golddrop) 
    {
        money += golddrop;
    }

    /// <summary>
    /// 构造函数
    /// </summary>
    public Enemy(string job, int totalhp, Transform position, Transform target, float direction, CharacterConsts.Belong belong,int damage,float speed,float power,int golddrop) : base(job, totalhp, position, target, direction, belong, damage)
    {
        this.job = job;
        this.totalhp = totalhp;
        this.position = position;
        this.target = target;
        this.direction = direction;
        this.speed = speed;
        this.power = power;
        this.golddrop = golddrop;
        this.damage = damage;
    }
}
