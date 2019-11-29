
// 繼承 類別: 可以享有原類別的成員(包含 欄位 方法 事件全部都有) 很重要!!!
public class Pipe : Floor
{
    //private void Start()
    //{
        //刪除(此遊戲物件  2.3秒延遲)
        //Destroy(gameObject, 3f);
    //}




    private void OnBecameInvisible()
    {
        
        Destroy(gameObject, 2.5f);
    }
}