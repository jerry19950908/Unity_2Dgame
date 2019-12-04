using UnityEngine;
using UnityEngine.UI;              //引用 介面UI   API
using UnityEngine.SceneManagement; //引用 場景管理 API

public class ReplayExit : MonoBehaviour
{
    /// <summary>
    ///  重新遊戲
    /// </summary>
    public void Replay()
    {
        print("重新遊戲");

        // Application.LoadLevel("遊戲場景");  //舊版 API (隨時有可能被刪掉)

        SceneManager.LoadScene("遊戲場景");  // 新版 API (建議用新的)
    }

    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void Exit()
    {
        print("離開遊戲");

        Application.Quit(); //發佈遊戲 按鈕才有辦法離開遊戲 不可能關掉Unity

    }




}
