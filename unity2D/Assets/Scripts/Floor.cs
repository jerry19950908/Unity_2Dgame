using UnityEngine;

public class Floor : MonoBehaviour
{
    
    [Header("速度"), Range(0.5f, 10f)]
    public float speed = 1.5f;

    public Transform floor;

    private void Update()
    {
        floor.Translate(-speed, 0, 0);
    }

    /// <summary>
    /// 地板移動方法
    /// </summary>
    private void Move()
    {

    }

}
