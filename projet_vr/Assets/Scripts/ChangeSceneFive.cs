using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeSceneFive : MonoBehaviour
{
    public Animator Sphere;
    public Animator indice;
    public Animator interfaceOpen;
    
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
        }

        if (other.tag == "interface")
        {
            interfaceOpen.Play("interfaceOpen");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "tavleau")
        {

            Sphere.Play("sphereFerme");
            indice.Play("indiceFerme");

        }

        if (other.tag == "interface")
        {
            interfaceOpen.Play("interfaceFermer");
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
