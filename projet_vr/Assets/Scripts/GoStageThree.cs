using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoStageThree : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {


        if (other.tag == "nextToThree")
        {
            StartCoroutine("chargerNiveau");
        }
    }
    IEnumerator chargerNiveau()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Stage3");
        yield break;
    }
}
