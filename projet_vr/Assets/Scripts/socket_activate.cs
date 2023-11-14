using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class socket_activate : MonoBehaviour
{
    public GameObject mur;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("crochet"))
        {
            mur.SetActive(false);
        }
    }
    
}
