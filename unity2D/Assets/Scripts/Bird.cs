using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度"), Range(100, 1200)]
    public int high = 250;
    [Header("旋轉角度")] //需要微調的數值 建議給他一個欄位比較好調整
    public float angle = 5;
    [Header("是否死亡"), Tooltip("判斷有沒有死亡")]
    public bool dead;



    public GameObject goScore, goSpawnpipe;

    public Rigidbody2D flyup;
   

    /// <summary>
    /// 小雞跳躍功能
    /// </summary>
    private void Jump()
    {
        if (dead)    //如果 死亡為勾選狀態 = true 就跳出 不執行下面的程式動作
        {                           //也可以寫成  if(dead) return;
            return;
        }



        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            goScore.SetActive(true);     //當if執行的時候 會出現場景上的物件
            goSpawnpipe.SetActive(true);

            flyup.Sleep(); //sleep睡著 = 重設所有物理設定 
            
            flyup.gravityScale = 1f; //按左鍵的時候 小雞恢復重力 = 1 

            flyup.AddForce(Vector2.up * high);
            //讓小雞產生向上的推力 2D剛體 用Vector2
            //另一個寫法  flyup.AddForce(new Vector2(0, high));   

        }

        flyup.SetRotation(angle* flyup.velocity.y);
        //設定旋轉角度
        //不放在if欄位,滑鼠按一次,他只會執行一次 拉出來會在update執行

        //velocity.y (y軸為正值乘上angle為正值,頭會往上  飛飛小雞方向是往上往下 所以只要看y軸
        //            y軸為負值乘上angle為正值,頭會往下)
    }


    /// <summary>
    /// 小雞是否死亡
    /// </summary>
    private void Dead()
    {
        dead = true;
    }

    /// <summary>
    /// 通過水管
    /// </summary>
    private void Pass()
    {

    }

    private void Update()
    {
        Jump();
    }

    //碰撞開始事件:物件碰撞開始時 執行一次 (紀錄碰撞物件資訊)
    private void OnCollisionEnter2D(Collision2D collision)
    {
      //碰撞.遊戲物件.場景上的名稱
      //print(collision.gameObject.name); 顯示在 Console上面
        Dead();
    }

    //觸發開始事件:物件觸發開始時 執行一次 (紀錄觸發物件資訊) - 針對有勾選 isTrigger的物件 (有設定Collider碰撞器)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Dead();
    }









}
