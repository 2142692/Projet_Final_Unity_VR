using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class joueur : MonoBehaviour
{
    
    public Animator ascenseur;
    
    public Transform groundCheck;
    public GameObject cube;
    public float groundDistance;
    public LayerMask groundMask;
    private Vector3 velocity;
    private bool isGrounded;
    public GameObject plateforme;
    public GameObject player;
    public GameObject empty;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ascenseur")
        {
            player.transform.parent = plateforme.transform;
            ascenseur.Play("monte");
            ascenseur.Play("plateformeTwo");
            ascenseur.Play("plateformeOne");
            ascenseur.Play("plateformeFour");
        }

        

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "ascenseur")
        {
            player.transform.parent = empty.transform;
        }

    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

    }
}
