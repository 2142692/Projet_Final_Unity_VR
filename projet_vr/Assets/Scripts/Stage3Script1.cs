using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stage3Script1 : MonoBehaviour
{
    public int valeurChiffre = 1; // Modifier la valeur pour correspondre au chiffre à ajouter
    public GestionCodeOrdi gestionCode; // Référence au script de gestion du code

    public void Execute()
    {
        gestionCode.AjouterChiffre(valeurChiffre); // Appel de la méthode AjouterChiffre() du script GestionCode
    }
}