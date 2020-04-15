using UnityEngine;

public class Card : MoonBehaviour
{
    // rng(random number generator) 1,2分别对应随机品质与种类
    private float rng1;
    private int rng2;
    // 影响因子 以供游戏参数可以影响抽卡概率
    private float factor;

    // rng的数值确定
    private void Rng()
    {
        rng1 = Random.Range(0f, 100f)   // 生成0~100的随机浮点数
        rng2 = Random.Range(0,5)    // 生成随机整数（数值待定，暂用0~5）
    }

    // 影响因子的确定
    private virtual void Factor()
    {
        factor = 0; // 算法待定
    }

    // 静态函数 抽卡
    public static void DrawCard()
    {
        Factor();
        Rng();
        // 算法待定
        // 根据抽卡结果创建防守单位实例待补充

    }

}