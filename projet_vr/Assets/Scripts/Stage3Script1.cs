using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stage3Script1 : MonoBehaviour
{
    public int valeurChiffre = 1; // Modifier la valeur pour correspondre au chiffre � ajouter
    public GestionCodeOrdi gestionCode; // R�f�rence au script de gestion du code

    public void Execute()
    {
        gestionCode.AjouterChiffre(valeurChiffre); // Appel de la m�thode AjouterChiffre() du script GestionCode
    }
}