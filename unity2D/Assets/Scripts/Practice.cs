using UnityEngine; //運用Unity API
//     類別  類別名稱
public class Practice: MonoBehaviour
{
    //程式內容

    // 宣告變數 - 定義欄位 Field
    // (修飾詞) 欄位類型 欄位名稱 結束
    // 私人 - 隱藏(private)
    // 公開 - 顯示(public)
    [Header("金幣")]
    [Range(1, 9999)]
    public int coin = 999;             // 整數 - 0
    [Header("速度"), Range(0.1f, 99.9f)]
    public float speed =1.5f;          // 浮點數 - 0
    [Tooltip("這是喝了會死掉的藥水")]
    public string prop = "紅色藥水";   // 字串 - ""
    public bool dead = false;           // 布林值 - false

    //事件
    //遊戲播放時會執行一次
    private void Start()
    {
        print("哈囉~沃德");
    }

    private void Update()
    {
        print("嗨");
  
    }
}
