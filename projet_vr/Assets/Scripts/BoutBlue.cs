using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoutBlue : MonoBehaviour
{
    public int valeurChiffre = 6; 
    public GestionCode gestionCode;

    public void AjouterChiffre()
    {
        gestionCode.AjouterChiffre(valeurChiffre);
    }
}