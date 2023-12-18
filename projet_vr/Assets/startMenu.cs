using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class startMenu : MonoBehaviour
{
    
    public void OnPress()
    {
        StartCoroutine("chargerNiveau");
    }


    IEnumerator chargerNiveau()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Stage2");
        yield break;
    }

  
}
