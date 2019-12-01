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

    //把 Bestpoint Spawnpipe Gamepoint類別拿來使用
    public Bestpoint gameover;
    public Spawnpipe spawn;
    public Gamepoint add;

    [Header("音效區域")]
    public AudioSource aud;
    public AudioClip soundjump, soundhit, soundpass;



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
            aud.PlayOneShot(soundjump, 2f);    //音源.撥放一次 (音效, 音量)
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
        gameover.Gameover();
        spawn.Gameover();
        Floor.speed = 0; //變靜態成員之後 可以從其他類別使用此方法(類似API用法)!!
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
        if(collision.gameObject.name == "水管(下)" || collision.gameObject.name == "水管(上)")
        {
            Dead();
            aud.PlayOneShot(soundhit, 2f);    //音源.撥放一次 (音效, 音量)
        }
       
    }

    //觸發開始事件:物件觸發 開始離開此物件時 執行一次(紀錄觸發物件資訊)
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "通過水管")
        {
            add.Addpoint();
            aud.PlayOneShot(soundpass, 2f);    //音源.撥放一次 (音效, 音量)

        }
    }








}
