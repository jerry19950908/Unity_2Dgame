
// 繼承 類別: 可以享有原類別的成員(包含 欄位 方法 事件全部都有) 很重要!!!
public class Pipe : Floor
{
    //private void Start()
    //{
        //刪除(此遊戲物件  2.3秒延遲)
        //Destroy(gameObject, 3f);
    //}


    //使用該事件的物件 要加 Mesf Renderer
    //在所有相機看不到時 執行一次
    private void OnBecameInvisible()
    {
        
        Destroy(gameObject, 2f);
    }



    //使用該事件的物件 要加 Mesf Renderer
    //在所有相機看到時 執行一次
    private void OnBecameVisible()
    {
        
    }



}