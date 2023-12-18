using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoutGreen : MonoBehaviour
{
    public int valeurChiffre = 4;
    public GestionCode gestionCode;

    public void AjouterChiffre()
    {
        gestionCode.AjouterChiffre(valeurChiffre);
    }
}