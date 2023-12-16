using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (other.tag == "scenefourth")
            {

                StartCoroutine("chargerNiveausup");
            };
    }
    IEnumerator chargerNiveausup()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Stage4");
        yield break;
    }
}
