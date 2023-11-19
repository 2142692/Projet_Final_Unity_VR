using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class code : MonoBehaviour
{
    public Text Ans;
    public Animator corps;
    public GameObject mur;
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
            mur.SetActive(false);
        }

        else
        {
            Ans.text = "nope";
        }

    }

}
