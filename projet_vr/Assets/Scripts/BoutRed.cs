using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoutRed : MonoBehaviour
{
    public int valeurChiffre = 5;
    public GestionCode gestionCode;

    public void AjouterChiffre()
    {
        gestionCode.AjouterChiffre(valeurChiffre);
    }
}