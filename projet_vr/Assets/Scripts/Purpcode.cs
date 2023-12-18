using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Purpcode : MonoBehaviour
{
    public int valeurChiffre = 2; // Modifier la valeur pour correspondre au chiffre à ajouter
    public GestionCode gestionCode;

    public void AjouterChiffre()
    {
        gestionCode.AjouterChiffre(valeurChiffre);
    }
}