using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class declancheAnimStage3Monte : MonoBehaviour
{
    public Animator animator;
    public Animator canvas;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ascenseur")) 
        {
            animator.Play("monteStage3"); 
            Debug.Log("ascenseur Devrait Fonctionner");
            
        }
        if (other.tag == "scenefourth")
            {

                StartCoroutine("chargerNiveausup");
            };
    }
    IEnumerator chargerNiveausup()
    {
        canvas.SetTrigger("Debut");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Stage4");
        yield break;
    }
}
