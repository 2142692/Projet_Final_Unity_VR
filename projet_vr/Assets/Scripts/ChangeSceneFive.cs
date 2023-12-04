using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeSceneFive : MonoBehaviour
{
    public Animator canvas;
    private void OnTriggerEnter(Collider other)
    {
        

       if (other.tag == "sceneFive") 
        {
            StartCoroutine("chargerNiveau");
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
