using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManivelleGiver : MonoBehaviour
{
    public Animator Chest;
    public AudioClip audioClip; // Votre AudioClip

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("manivelle"))
        {
            Chest.Play("coffret");

            GameObject audioObject = new GameObject("AudioObject"); // Crée un GameObject pour l'AudioSource
            AudioSource audioSource = audioObject.AddComponent<AudioSource>(); // Ajoute un AudioSource au GameObject

            if (audioClip != null)
            {
                audioSource.PlayOneShot(audioClip); // Joue l'AudioClip une seule fois
                Destroy(audioObject, audioClip.length); // Détruit le GameObject après la durée de l'AudioClip pour libérer les ressources
            }
            else
            {
                Debug.LogWarning("AudioClip non défini !");
            }
        }
    }
}