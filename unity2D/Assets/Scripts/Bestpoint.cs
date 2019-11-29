using UnityEngine;

public class Bestpoint : MonoBehaviour
{
    [Header("最佳分數"), Range(0, 9999)]
    public int point = 0;
    [Header("遊戲結束")]
    public GameObject gofinal;

    /// <summary>
    /// 最高分數設定
    /// </summary>
    private void Sethighpoint()
    {

    }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    //改成public 可以讓其他類別繼承這裡的成員 如果是private 只能在該類別裡使用
    public void Gameover()
    {
        gofinal.SetActive(true);

    }
}
