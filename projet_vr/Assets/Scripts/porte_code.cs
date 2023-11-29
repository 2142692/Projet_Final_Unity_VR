using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class porte_code : MonoBehaviour
{
    
    public Text Ans;
    public Animator armoire;
    
    private string Answer = "1751";

    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

public void Execute()
    {
        if(Ans.text == Answer)
        {
            Ans.text = "correct";
            armoire.Play("armoire");
            
            
        }

        else
        {
            Ans.text = "";
           
        }

    }

}
