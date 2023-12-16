using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class declancheAnimStage3Monte : MonoBehaviour
{
    public Animator animator; // Référence vers l'animator à déclencher

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ascenseur")) // Vérifie si le joueur entre dans la zone
        {
            animator.Play("monteStage3"); // Déclenche l'animation
            Debug.Log("ascenseur Devrait Fonctionner");
        }
    }
}
