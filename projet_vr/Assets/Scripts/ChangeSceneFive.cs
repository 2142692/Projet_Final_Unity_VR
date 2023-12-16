using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeSceneFive : MonoBehaviour
{
    public Animator Sphere;
    public Animator indice;
    public Animator interfaceOpen;
    public GameObject AudioInterOuvert;
    public GameObject AudioInterFermer;
    public GameObject AudioCouleurFerme;
    public GameObject AudioCouleurOuvre;
    public Animator canvas;
    private void OnTriggerEnter(Collider other)
    {
        

       if (other.tag == "sceneFive") 
        {
            StartCoroutine("chargerNiveau");
        }

        if (other.tag == "tavleau")
        {

            Sphere.Play("sphere");
            indice.Play("indice");
            AudioInterFermer.SetActive(false);
            AudioInterOuvert.SetActive(true);
        }

        if (other.tag == "interface")
        {
            interfaceOpen.Play("interfaceOpen");
            AudioCouleurFerme.SetActive(false);
            AudioCouleurOuvre.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "tavleau")
        {

            Sphere.Play("sphereFerme");
            indice.Play("indiceFerme");
            AudioInterOuvert.SetActive(false);
            AudioInterFermer.SetActive(true);
        }

        if (other.tag == "interface")
        {
            interfaceOpen.Play("interfaceFermer");
            AudioCouleurOuvre.SetActive(false);
            AudioCouleurFerme.SetActive(true);
        }
    }

    IEnumerator chargerNiveau()
    {
        canvas.SetTrigger("Debut");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Stage5");
        yield break;
    }
}
