using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuitetManivelle : MonoBehaviour
{
    public Animator ManivelleAnim;
    public GameObject manivelleDisp;
    public GameObject manivelleApp;

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("puit"))
        {
            if (manivelleApp != null && ManivelleAnim != null && manivelleDisp != null)
            {
                manivelleApp.SetActive(true);
                ManivelleAnim.Play("manTourne");
                manivelleDisp.SetActive(false);
            }
           
        }
    }
}