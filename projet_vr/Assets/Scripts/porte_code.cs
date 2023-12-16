using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class porte_code : MonoBehaviour
{
    
    public Text Ans;
    public Animator armoire;
    public GameObject audioArmoire;
    public GameObject audioButtonCode;
    private string Answer = "7151";

    public void Number(int number)
    {
        Ans.text += number.ToString();
        audioButtonCode.SetActive(false);
        audioButtonCode.SetActive(true);
    }

public void Execute()
    {
        if(Ans.text == Answer)
        {
            Ans.text = "correct";
            armoire.Play("armoire");
            audioArmoire.SetActive(true);
            audioButtonCode.SetActive(false);
            audioButtonCode.SetActive(true);
        }

        else
        {
            Ans.text = "";
            audioButtonCode.SetActive(false);
            audioButtonCode.SetActive(true);
        }

    }

}
