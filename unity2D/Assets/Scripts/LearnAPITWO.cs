using UnityEngine;

public class LearnAPITWO : MonoBehaviour
{
    //存放類別欄位
    public Bird Test;

    private void Start()
    {
        //設定其他類別的欄位
        Test.high = 99;

        print("小雞的跳躍欄位" + Test.high);
    
    }
}