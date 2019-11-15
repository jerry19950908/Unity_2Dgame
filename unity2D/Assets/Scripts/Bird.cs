using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度"), Range(50, 100)]
    public int high = 75;
    [Header("是否死亡"), Tooltip("判斷有沒有死亡")]
    public bool dead;



    /// <summary>
    /// 小雞跳躍功能
    /// </summary>
    private void Jump()
    {

    }


    /// <summary>
    /// 小雞是否死亡
    /// </summary>
    private void Dead()
    {

    }

    /// <summary>
    /// 通過水管
    /// </summary>
    private void Pass()
    {

    }


}
