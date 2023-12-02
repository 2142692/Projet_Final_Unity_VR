using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class couleur_code : MonoBehaviour
{
    public Text Ans;
    private string Answer = "1234";

    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    public void Execute()
    {
        if (Ans.text == Answer)
        {
            Ans.text = "yes";
            
        }

        else
        {
            Ans.text = "";
            
        }

    }
}
