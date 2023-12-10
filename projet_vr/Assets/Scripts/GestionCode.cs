using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionCode : MonoBehaviour
{
    public string codeSouhaite = "5324"; // Le code � deviner
    public TextMeshPro affichageCode; // Le texte o� le code est affich�

    private string codeEnCours = ""; // Le code en cours de saisie

    public void AjouterChiffre(int chiffre)
    {
        if (codeEnCours.Length < 4)
        {
            codeEnCours += chiffre.ToString();
            affichageCode.text = codeEnCours;

            Debug.Log("Chiffre ajout� : " + chiffre);

            if (codeEnCours.Length == 4)
            {
                VerifierCode();
            }
        }
    }

    private void VerifierCode()
    {
        if (codeEnCours == codeSouhaite)
        {
            Debug.Log("R�ussi ! Le code est correct.");
        }
        else
        {
            Debug.Log("Rat�. R�essayez.");
        }
        codeEnCours = "";
        affichageCode.text = codeEnCours;
    }
}
