using UnityEngine;

public class Gamepoint : MonoBehaviour
{
    [Header("分數"), Range(0,9999)]
    public int point = 0;


    /// <summary>
    /// 加分數
    /// </summary>
    /// <param name="add">添加分數預設值為 1分</param>
    private void Addpoint(int add = 1)
    {

    }
}
