using UnityEngine;

public class Card : MoonBehaviour
{
    // rng(random number generator) 1,2�ֱ��Ӧ���Ʒ��������
    private float rng1;
    private int rng2;
    // Ӱ������ �Թ���Ϸ��������Ӱ��鿨����
    private float factor;

    // rng����ֵȷ��
    private void Rng()
    {
        rng1 = Random.Range(0f, 100f)   // ����0~100�����������
        rng2 = Random.Range(0,5)    // ���������������ֵ����������0~5��
    }

    // Ӱ�����ӵ�ȷ��
    private virtual void Factor()
    {
        factor = 0; // �㷨����
    }

    // ��̬���� �鿨
    public static void DrawCard()
    {
        Factor();
        Rng();
        // �㷨����
        // ���ݳ鿨����������ص�λʵ��������

    }

}