using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionOrdinateurRetour : MonoBehaviour
{
    public Camera vueJoueur; 
    public Camera vueOrdinateur; 

    void Start()
    {
        
        vueOrdinateur.enabled = false;
    }

    void OnMouseDown()
    {
        
        ActiverVueOrdinateur();
    }

    public void ActiverVueOrdinateur()
    {
       
        vueOrdinateur.enabled = false;
        vueJoueur.enabled = true;

          }

    public void RetourVueJoueur()
    {
        vueOrdinateur.enabled = true;
        vueJoueur.enabled = false;
 }
}
