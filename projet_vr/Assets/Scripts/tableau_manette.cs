using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tableau_manette : MonoBehaviour
{
    public Animator switchManette;
    public Animator btnCarre;
    public Animator levierManette;
    public Text Reponse;
    public GameObject plane;
    public GameObject AudioManette;
    public GameObject AudioLevier;
    public GameObject AudioCarree;
    public Animator diffusion;
    private string Answer = "12";
    public void Number(int number)
    {
    Reponse.text += number.ToString();
    }

    public void Execute()
    {
        if (Reponse.text == Answer)
        {
            plane.SetActive(true);
            diffusion.Play("plane");
        }

        else
        {
            Reponse.text = "";
        }

    }

    public void ActivateSwitch()
    {
        switchManette.Play("switch");
        AudioManette.SetActive(false);
        AudioManette.SetActive(true);
    }

    public void ActivatebtnCarre()
    {
        btnCarre.Play("btnCarre");
        AudioCarree.SetActive(false);
        AudioCarree.SetActive(true);

    }

    public void ActivateLevier()
    {
        levierManette.Play("levierAnim");
        AudioLevier.SetActive(false);
        AudioLevier.SetActive(true);
    }

}
