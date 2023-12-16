using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class couleur_code : MonoBehaviour
{
   
    public GameObject scan;
    public GameObject audioScan;
    public GameObject audiotele;
    public GameObject audiobtn;
    public GameObject audioAlarmeOne;
    public GameObject audioAlarmeTwo;
    public GameObject audioPorteMetal;
    public GameObject audioFenetre;
    public GameObject audioRobot;
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
            audioAlarmeOne.SetActive(true);
            audioAlarmeTwo.SetActive(true);
            audioPorteMetal.SetActive(true);
            audioRobot.SetActive(true);
            audioFenetre.SetActive(true);
        }

        else
        {
            Ans.text = "";
            
        }

    }

    public void ActivatebtnRed()
    {
        btnRed.Play("boutonRouge");
        audiobtn.SetActive(false);
        audiobtn.SetActive(true);
    }

    public void ActivatebtnYellow()
    {
        btnYellow.Play("boutonJaune");
        audiobtn.SetActive(false);
        audiobtn.SetActive(true);

    }

    public void ActivatebtnGreen()
    {
        btnGreen.Play("boutonVert");
        audiobtn.SetActive(false);
        audiobtn.SetActive(true);

    }

    public void ActivatebtnBlue()
    {
        btnBlue.Play("boutonBleu");
        audiobtn.SetActive(false);
        audiobtn.SetActive(true);

    }

    public void ActivatebtnGrey()
    {
        btnGrey.Play("boutonGris");
        audiobtn.SetActive(false);
        audiobtn.SetActive(true);

    }

    public void ActivateEmpreinte()
    {
        empreinte.Play("empreinte");
        danger.Play("danger");
        audioScan.SetActive(false);
        audioScan.SetActive(true);
        audiotele.SetActive(true);

    }

}
