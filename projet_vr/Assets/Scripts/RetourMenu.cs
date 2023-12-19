using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class RetourMenu : MonoBehaviour
{
    public Animator canvas;
    public void BtnMenu()
    {
        StartCoroutine("Retour");
    }


    IEnumerator Retour()
    {
        canvas.SetTrigger("Debut");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Menu");
        yield break;
    }

}
