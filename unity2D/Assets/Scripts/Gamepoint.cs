 using UnityEngine;
 using UnityEngine.UI; //引用 Unity UI所有成員  ex: text


public class Gamepoint : MonoBehaviour
{
    [Header("分數"), Range(0,9999)]
    public int point = 0;
    public Text textpoint;

    public Bestpoint bestpoint;

  
    /// <summary>
    /// 加分數
    /// </summary>
    /// <param name="add">添加分數預設值為 1分</param>
    /// 改成public 可以讓其他類別繼承這裡的成員 如果是private 只能在該類別裡使用
    public void Addpoint(int add = 1)
    {
        print("加分~~");
        point = point + add;
        textpoint.text = point.ToString(); //把分數也可以當成引用字串

        bestpoint.Sethighpoint();
    }
}
