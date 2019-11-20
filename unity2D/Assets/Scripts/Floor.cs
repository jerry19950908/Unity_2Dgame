using UnityEngine;

public class Floor : MonoBehaviour
{
    
    [Header("速度"), Range(0.5f, 10f)]
    public float speed = 1.5f;

    public Transform floor;

    

    /// <summary>
    /// 地板移動方法
    /// </summary>
    private void Move()
    {
        //Time.deltatime 一個影格的時間(根據電腦效能不同)
        floor.Translate(-speed * Time.deltaTime, 0, 0);
    }


    private void Update()
    {
        Move();
    }
}
