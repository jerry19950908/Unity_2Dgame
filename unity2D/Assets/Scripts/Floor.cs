using UnityEngine;

public class Floor : MonoBehaviour
{
    //靜態成員  此類別可以在其他類別共用
    //[Header("速度"), Range(0.5f, 10f)] = 變靜態成員之後  他就只剩下預設值 所以要先設定好!!
    public static float speed = 4.2f;

    public Transform floor;

    

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
