using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManivelleGiver : MonoBehaviour
{
    public Animator Chest;
    public AudioClip audioClip; 

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("manivelle"))
        {
            Chest.Play("coffret");

            GameObject audioObject = new GameObject("AudioObject"); 
            AudioSource audioSource = audioObject.AddComponent<AudioSource>(); 

            if (audioClip != null)
            {
                audioSource.PlayOneShot(audioClip); 
                Destroy(audioObject, audioClip.length); 
            }
            else
            {
                Debug.LogWarning("AudioClip non défini !");
            }
        }
    }
}