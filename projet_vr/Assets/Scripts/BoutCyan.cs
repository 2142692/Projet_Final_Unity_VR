using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoutCyan : MonoBehaviour
{
    public int valeurChiffre = 1; // Modifier la valeur pour correspondre au chiffre � ajouter
    public GestionCode gestionCode; // R�f�rence au script de gestion du code

    void OnMouseDown()
    {
        gestionCode.AjouterChiffre(valeurChiffre); // Appel de la m�thode AjouterChiffre() du script GestionCode
    }
}