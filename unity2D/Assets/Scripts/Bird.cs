using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度"), Range(50, 100)]
    public int high = 75;
    [Header("是否死亡"), Tooltip("判斷有沒有死亡")]
    public bool dead;
}
