using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3Script4 : MonoBehaviour
{
    public int valeurChiffre = 4; // Modifier la valeur pour correspondre au chiffre � ajouter
    public GestionCodeOrdi gestionCode; // R�f�rence au script de gestion du code

    void OnMouseDown()
    {
        gestionCode.AjouterChiffre(valeurChiffre); // Appel de la m�thode AjouterChiffre() du script GestionCode
    }
}