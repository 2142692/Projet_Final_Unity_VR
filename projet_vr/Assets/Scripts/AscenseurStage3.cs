using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AscenseurStage3 : MonoBehaviour
{
    public GameObject Lumieretransit;
    public GameObject Lumieretransit2;

    public Animator ascenseur3;
    public Animator ascenseur3Second;

    public AudioClip audioClip;
    

    //ANIMATION DE LA PORTE ACSENSEUR


    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("StageTree"))
        {
            Lumieretransit.SetActive(true);
            Lumieretransit2.SetActive(true);

            Debug.Log("AscenseurOuvre");
            ascenseur3.Play("Animstage3");
            ascenseur3Second.Play("Animstage3second");

            GameObject audioObject = new GameObject("AudioObject");
            AudioSource audioSource = audioObject.AddComponent<AudioSource>();
            audioSource.PlayOneShot(audioClip);
            Destroy(audioObject, audioClip.length);
        }
    }
}
