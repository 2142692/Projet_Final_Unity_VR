using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManivelleGiver : MonoBehaviour
{
    public Animator Chest;
    public void OnTriggerEnter(Collider collision)
    {
        
        if (collision.CompareTag("manivelle"))
        {
            Chest.Play("coffret");
        }
    }
    


}
