using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AscenseurStage3 : MonoBehaviour
{
    public Animator ascenseur3;
    public Animator ascenseur3Second;

    // Fonction pour arrêter l'animation à la fin
    

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("StageTree"))
        {
            Debug.Log("AscenseurOuvre");
            ascenseur3.Play("Animstage3");
            ascenseur3Second.Play("Animstage3second");
        }
    }
}
