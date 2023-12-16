using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class active_engrenage : MonoBehaviour
{
    public Animator porte;
    public Animator portedeux;
    public Animator mecanismeone;
    public Animator mecanismegrand;
    public Animator mecanismemoyen;
    public GameObject audioPorte;
    public GameObject audioEngrenage;
   public void Hover()
    {
            mecanismeone.Play("mecanismeOne");
            mecanismegrand.Play("mecanismeGrand");
            mecanismemoyen.Play("mecanismeMoyen");
            porte.Play("porteopen");
        portedeux.Play("porteopenTwo");
        audioPorte.SetActive(true);
        audioEngrenage.SetActive(true);
    }
}
