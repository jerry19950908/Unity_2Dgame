using UnityEngine;
using UnityEngine.UI;

public class Bestpoint : MonoBehaviour
{
    [Header("最佳分數"), Range(0, 9999)]
    public int bestpoint = 0;
    [Header("遊戲結束")]
    public GameObject gofinal;

    public Gamepoint gamepoint;

    public Text textbest;

    /// <summary>
    /// 最高分數設定
    /// </summary>
    public void Sethighpoint()
    {
        if (gamepoint.point > bestpoint)
        {
            PlayerPrefs.SetInt("最佳分數", gamepoint.point);
        }
    } 

    public void Start() //遊戲載入時 會一直儲存這筆資料 所以要用start事件
    {
        bestpoint = PlayerPrefs.GetInt("最佳分數"); 
        textbest.text = bestpoint.ToString();
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
