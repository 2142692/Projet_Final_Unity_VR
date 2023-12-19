using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class startMenu : MonoBehaviour
{
    public Animator canvas;
    public void OnPress()
    {
        StartCoroutine("chargerNiveau");
            
    }


    IEnumerator chargerNiveau()
    {
        canvas.SetTrigger("Debut");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Stage1");
        yield break;
    }

  
}
