using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class code : MonoBehaviour
{
    public Text Ans;
    public Animator corps;

    private string Answer = "4213";

    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    public void Execute()
    {
        if(Ans.text == Answer)
        {
            Ans.text = "yes";
            corps.Play("folie");
        }

        else
        {
            Ans.text = "nope";
        }

    }

}
