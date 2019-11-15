using UnityEngine;

public class Learnmethod : MonoBehaviour
{   
    //自訂方法 不會執行 要呼叫
    // void 無傳回
   private void Test()
    {
        print("測試方法!");
    }

    


    private void Drive(int speed)
    {
        print("引擎聲音");
        print("排氣管特效");
        print("開車時速:" + speed); 
    }

 //可設定多重參數(不限制)   參數1      參數2         參數3
 //參數給予指定值一定要放在最右方 ex:(參數1, 參數2, 參數3 = ~~~)
    private void Shoot(int count,string property, string direction)
    {
        print("弓箭數量:" + count);
        print("弓箭屬性:" + property);
        print("弓箭方向:" + direction);
    }


    //有傳回方法
    private int Ten()
    {
        return 10;
    }

    



    private void Start()
    {
        //呼叫方法
        Test();   //無傳回

        Drive(18);

        Shoot(58, "火焰", "前方");
        
        
        //有傳回
        int a = Ten(); //第一種傳回方式 自訂名稱
        print("有傳回方法:" + a);

        print("有傳回方法:" + Ten());
        // 第二種傳回方式 不用自訂名稱 直接把上面的整數方法名稱拿下來用

       



    }
}
