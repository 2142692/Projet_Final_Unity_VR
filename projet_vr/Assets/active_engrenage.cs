using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class active_engrenage : MonoBehaviour
{
    public Animator porte;
    public Animator mecanismeone;
    public Animator mecanismegrand;
    public Animator mecanismemoyen;
   private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("poto"))
        {
            mecanismeone.Play("mecanismeOne");
        }

        if (mecanismeone == true)
        {
            
            mecanismegrand.Play("mecanismeGrand");
            mecanismemoyen.Play("mecanismeMoyen");
            porte.Play("porteopen");
        }
    }

    
}
