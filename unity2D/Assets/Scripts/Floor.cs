using UnityEngine;

public class Floor : MonoBehaviour
{
    //靜態成員  此類別可以在其他類別共用
    //[Header("速度"), Range(0.5f, 10f)] = 變靜態成員之後  他就只剩下預設值 所以要先設定好!!
    //靜態欄位 再重新載入場景時 不會還原預設值 所以要用start事件保持每次重新開遊戲時地板跟水管都會動
    public static float speed = 4.2f;

    public Transform floor;

    private void Start() //遊戲重新啟動 可以用start事件來重新執行一次
    {
        speed = 4.2f;
    }

    /// <summary>
    /// 地板移動方法
    /// </summary>
    private void Move()
    {
        //Time.deltatime 一個影格的時間(根據電腦效能不同)
        floor.Translate(-speed * Time.deltaTime, 0, 0);
    }


    private void Update()
    {
        Move();
    }
}
