using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionOrdinateur : MonoBehaviour
{
    public Camera vueJoueur; // La cam�ra de la vue du joueur
    

    void Start()
    {
        // Assurez-vous que la cam�ra de l'ordinateur est d�sactiv�e au d�but
       
    }

    private void OnTriggerEnter(Collider other)
    {
        // Lorsque l'ordinateur est cliqu�, active la vue de l'ordinateur
        if(other.tag == "Player")
        ActiverVueOrdinateur();
    }

    public void ActiverVueOrdinateur()
    {
        // D�sactive la cam�ra du joueur et active la cam�ra de l'ordinateur
       

        // Verrouille l'orientation du joueur (d�sactive les contr�les de mouvement ou de regard)
        // Assurez-vous d'avoir un script qui contr�le cela pour �viter le glitching des mains
        // par exemple : gestion des contr�les de mouvement ou de regard dans votre script de mouvement du joueur
        // Pour d�sactiver les mouvements du joueur : joueur.GetComponent<MovementScript>().enabled = false;
    }

    public void RetourVueJoueur()
    {
        // Active la cam�ra du joueur et d�sactive la cam�ra de l'ordinateur
       
        // R�active les contr�les de mouvement et de regard du joueur
        // Assurez-vous d'avoir un script qui g�re cela pour revenir � la perspective normale du joueur
        // par exemple : r�activation des contr�les de mouvement ou de regard
        // Pour r�activer les mouvements du joueur : joueur.GetComponent<MovementScript>().enabled = true;
    }
}