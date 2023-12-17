using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionOrdinateur : MonoBehaviour
{
    public Camera vueJoueur; // La caméra de la vue du joueur
    

    void Start()
    {
        // Assurez-vous que la caméra de l'ordinateur est désactivée au début
       
    }

    private void OnTriggerEnter(Collider other)
    {
        // Lorsque l'ordinateur est cliqué, active la vue de l'ordinateur
        if(other.tag == "Player")
        ActiverVueOrdinateur();
    }

    public void ActiverVueOrdinateur()
    {
        // Désactive la caméra du joueur et active la caméra de l'ordinateur
       

        // Verrouille l'orientation du joueur (désactive les contrôles de mouvement ou de regard)
        // Assurez-vous d'avoir un script qui contrôle cela pour éviter le glitching des mains
        // par exemple : gestion des contrôles de mouvement ou de regard dans votre script de mouvement du joueur
        // Pour désactiver les mouvements du joueur : joueur.GetComponent<MovementScript>().enabled = false;
    }

    public void RetourVueJoueur()
    {
        // Active la caméra du joueur et désactive la caméra de l'ordinateur
       
        // Réactive les contrôles de mouvement et de regard du joueur
        // Assurez-vous d'avoir un script qui gère cela pour revenir à la perspective normale du joueur
        // par exemple : réactivation des contrôles de mouvement ou de regard
        // Pour réactiver les mouvements du joueur : joueur.GetComponent<MovementScript>().enabled = true;
    }
}