using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class declancheAnimStage3Monte : MonoBehaviour
{
    public Animator animator; // R�f�rence vers l'animator � d�clencher

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ascenseur")) // V�rifie si le joueur entre dans la zone
        {
            animator.Play("monteStage3"); // D�clenche l'animation
            Debug.Log("ascenseur Devrait Fonctionner");
        }
    }
}
