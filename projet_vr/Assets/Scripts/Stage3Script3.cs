using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3Script3 : MonoBehaviour
{
    public int valeurChiffre = 3; // Modifier la valeur pour correspondre au chiffre à ajouter
    public GestionCodeOrdi gestionCode; // Référence au script de gestion du code

    void OnMouseDown()
    {
        gestionCode.AjouterChiffre(valeurChiffre); // Appel de la méthode AjouterChiffre() du script GestionCode
    }
}
