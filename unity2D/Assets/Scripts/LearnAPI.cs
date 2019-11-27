using UnityEngine;

public class LearnAPI : MonoBehaviour
{

    public Transform bird, floor;

    private void Start()
    {
        Debug.Log("一般!");
        Debug.LogWarning("警告!");
        Debug.LogError("錯誤!");

        //靜態屬性
        Debug.Log(Random.value);
        //靜態方法
        Debug.Log(Random.Range(1, 10));

        //非靜態屬性用法 需先定義欄位
        Debug.Log(bird.position);
        Debug.Log(floor.position);

    }

    //更新事件:偵測按鍵
    private void Update()
    {
        //類別.靜態方法(對應引數)
        print(Input.GetKeyDown("mouse 0"));  // 字串取得按鍵
        print(Input.GetKeyDown(KeyCode.Mouse1));// 列舉取得按鍵
    }
}
