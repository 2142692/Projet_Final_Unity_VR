using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoutYellow : MonoBehaviour
{
    public int valeurChiffre = 3; 
    public GestionCode gestionCode;

    public void AjouterChiffre()
    {
        gestionCode.AjouterChiffre(valeurChiffre);
    }
}