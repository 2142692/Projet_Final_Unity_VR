using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManivelleGiver : MonoBehaviour
{
    public Animator Chest;
    public GameObject manivelle;
    public void OnTriggerEnter(Collider collision)
    {
        
        if (collision.CompareTag("manivelle"))
        {
            manivelle.SetActive(true);
            Chest.Play("coffret");
        }
    }
    


}
