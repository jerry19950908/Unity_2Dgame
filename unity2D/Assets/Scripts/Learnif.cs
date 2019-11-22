using UnityEngine;

public class Learnif : MonoBehaviour
{

    public bool open;
    public int score;
    public int combo;

    private void Start()
    {
        //判斷式if
        // if(布林值) {當布林值為 true 才執行}
        if (true)
        {
            print("嗨");
        }
        


        //當布林值為true 會執行 if{}
        if (open)
        {
            print("開門~~");
        }
        //當布林值為 false 會直接 else{}
        else
        {
            print("關門~~");
        }




        if (score >= 60)
        {
            print("及格囉~~");
        }

        else if(score >= 40)
        {
            print("可補考");
        }

        else
        {
            print("你被當了~~");
        }

        
        if(combo >= 50 && combo < 100)
        {
            print("攻擊x2");
        }
        else if(combo >= 100 && combo < 150)
        {
            print("攻擊x5");
        }
        else if (combo >= 150)
        {
            print("攻擊x10");
        }
        else
        {
            print("攻擊x1");
        }
    }
}
