using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class couleur_code : MonoBehaviour
{
   
    public GameObject scan;
    public Animator empreinte;
    public Animator danger;
    public Animator securite;
    public Animator AmpouleOne;
    public Animator AmpouleTwo;
    public Animator AlarmeOne;
    public Animator AlarmeTwo;
    public Animator btnRed;
    public Animator btnYellow;
    public Animator btnGreen;
    public Animator btnBlue;
    public Animator btnGrey;
    public Text Ans;
    public Animator teteErreur;
    public Animator mainOneErreur;
    public Animator mainTwoErreur;
    public Animator porteFutur;
    private string Answer = "3421";

    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    public void Execute()
    {
        if (Ans.text == Answer)
        {
            Ans.text = "ERREUR";
            teteErreur.Play("tete");
            mainOneErreur.Play("mainFirst");
            mainTwoErreur.Play("mainTwo");
            porteFutur.Play("porteFutur");
            AmpouleOne.Play("ampouleOne");
            AmpouleTwo.Play("ampouleTwo");
            AlarmeOne.Play("alarmeOne");
            AlarmeTwo.Play("alarmeTwo");
            securite.Play("fenetreSecurite");
            scan.SetActive(false);

        }

        else
        {
            Ans.text = "";
            
        }

    }

    public void ActivatebtnRed()
    {
        btnRed.Play("boutonRouge");


    }

    public void ActivatebtnYellow()
    {
        btnYellow.Play("boutonJaune");


    }

    public void ActivatebtnGreen()
    {
        btnGreen.Play("boutonVert");


    }

    public void ActivatebtnBlue()
    {
        btnBlue.Play("boutonBleu");


    }

    public void ActivatebtnGrey()
    {
        btnGrey.Play("boutonGris");


    }

    public void ActivateEmpreinte()
    {
        empreinte.Play("empreinte");
        danger.Play("danger");


    }

}
