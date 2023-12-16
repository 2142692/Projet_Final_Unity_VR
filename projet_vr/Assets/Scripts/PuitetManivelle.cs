using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuitetManivelle : MonoBehaviour
{
    public Animator ManivelleAnim;
    public Animator grille;
    public GameObject manivelleDisp;
    public GameObject manivelleApp;
    public AudioClip audioClip;

    private AudioSource audioSource;

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("puit"))
        {
            if (manivelleApp != null && ManivelleAnim != null && manivelleDisp != null && audioClip != null)
            {
                manivelleApp.SetActive(true);
                ManivelleAnim.Play("manTourne");
                manivelleDisp.SetActive(false);
                grille.Play("grille2");
                Debug.Log("L'animation de la grille doit jouer");

                
                
                    // [AUDIO]
                    GameObject audioObject = new GameObject("AudioObject");
                    audioSource = audioObject.AddComponent<AudioSource>();
                    audioSource.loop = true; 
                    audioSource.clip = audioClip; 
                    audioSource.Play(); 
                
            }
        }
    }
}