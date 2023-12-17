using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startMenu : MonoBehaviour
{
    
    public void OnPress()
    {
        StartCoroutine("chargerNiveau");
    }

    IEnumerator chargerNiveau()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Stage1");
        yield break;
    }
}
