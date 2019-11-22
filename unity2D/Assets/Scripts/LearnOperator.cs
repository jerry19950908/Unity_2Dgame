using UnityEngine;

public class LearnOperator : MonoBehaviour

{
    public int a = 10, b = 3;
    public int c = 20, d = 7;
      private void Start()
    {
        #region 數學運算子
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b); //餘數 ex: 10/3 = 3.....1  取餘數

        // = 指定符號,右邊先運算
        a = a + 1;
        print(a);

        print(a++); //先輸出 a 在遞增  皆等於a+1
        print(++a); //先遞增再輸出 a   皆等於a+1

        a = a + 10; // 加10的意思
        a += 10;    // 同上  也可以運用到 += -=  *=  /=  %=
        print(a);
        #endregion

        #region 比較運算值(只會傳回布林值)
        print(c > d);  // true
        print(c < d);  // false
        print(c >= d); // true 
        print(c <= d); // false
        print(c == d); // 等於的意思  false 
        print(c != d); // 不等於的意思 true
        #endregion

        #region 邏輯運算值
        // 並且 && shift + 7
        // 只要有一個 false 結果為 false
        print(true && true);    // t
        print(true && false);   // f
        print(false && true);   // f
        print(false && false);  // f
        // 或者 || shift + 鎮
        // 只要有一個 true 結果為 true
        print(true || true);    // t
        print(true || false);   // t
        print(false || true);   // t
        print(false || false);  // f


        // 相反 !
        // 將布林值改為相反
        print(!true);     // false
        print(!false);    // true

        
        #endregion



    }





}
