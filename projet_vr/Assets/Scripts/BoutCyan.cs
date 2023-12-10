using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoutCyan : MonoBehaviour
{
    public int valeurChiffre = 1; // Modifier la valeur pour correspondre au chiffre à ajouter
    public GestionCode gestionCode; // Référence au script de gestion du code

    void OnMouseDown()
    {
        gestionCode.AjouterChiffre(valeurChiffre); // Appel de la méthode AjouterChiffre() du script GestionCode
    }
}