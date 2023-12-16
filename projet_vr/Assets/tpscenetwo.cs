using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tpscenefourt : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "scenetwo") {

            StartCoroutine("chargerNiveausup");
        };

    } 
    IEnumerator chargerNiveausup()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Stage2");
        yield break;
    }
}
