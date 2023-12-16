using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorfulDrink : MonoBehaviour
{
    public GameObject[] Superposition;
    
    private int index = 0; // superposition (Trop complex)

    void OnMouseDown()
    {
        index = (index + 1) % (Superposition.Length + 1); // Incrémente l'index circulairement

        if (index == 0)
        {
            
            foreach (GameObject obj in Superposition)
            {
                obj.SetActive(false);
            }
        }
        else
        {
            
            for (int i = 0; i < Superposition.Length; i++)
            {
                Superposition[i].SetActive(i == index - 1);
            }
        }
    }
}