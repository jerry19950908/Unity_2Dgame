using UnityEngine;

public class Spawnpipe : MonoBehaviour
{
    // GameObject 可以存放場景上的物件跟預製物
    public GameObject pipe;

   

    
    /// <summary>
    /// 生成水管的方法
    /// </summary>
    private void Spawn_Pipe() //生成方法 - 需要呼叫
    {
        // 三維向量 = new (x, y, z);  //給予隨機座標 Random.Range(隨機,範圍)
        //另一種寫法 
        // float r = Random.Range(-0.92f, 1.23f)
        // Vector3 pos = new Vector3(8, r, 0);
        Vector3 pos = new Vector3(8, Random.Range(-0.92f, 1.23f), 0);


        //Object可以不用打出來 因為它繼承了MonoBehaciour(裡面所有成員都可以使用)
        //MonoBehaciour包含了Object
        //Quaternion.identity = 零角度
        //實體化 - 生成 (物件)
        //Object.Instantiate(pipe)
        //進階寫法 可給座標 跟角度 參考 查詢google - Unity Instantiate (有各種API使用方法 要熟記!!)
        
        Object.Instantiate(pipe,pos, Quaternion.identity);  
    }

    private void Start() // 呼叫方法
    {
        //Spawn_Pipe(); 只會呼叫一次(start的關係)
        //延遲調用("方法名稱", 延遲時間);
        //Invoke("Spawn_Pipe", 1.5f);  - 1.5秒只會重複一次
        //延遲重複調用("方法名稱", 延遲時間, 重複頻率);
        InvokeRepeating("Spawn_Pipe", 0, 2.8f);

    }


    //改成public 可以讓其他類別繼承這裡的成員 如果是private 只能在該類別裡使用

    public void Gameover()
    {
        //取消延遲調用("方法名稱") 取消生成水管
        CancelInvoke("Spawn_Pipe");

    }



}
