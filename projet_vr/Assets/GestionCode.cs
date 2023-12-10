using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionCode : MonoBehaviour
{
    public string codeSouhaite = "5324"; // Le code à deviner
    public TextMeshPro affichageCode; // Le texte où le code est affiché

    private string codeEnCours = ""; // Le code en cours de saisie

    public void AjouterChiffre(int chiffre)
    {
        if (codeEnCours.Length < 4)
        {
            codeEnCours += chiffre.ToString();
            affichageCode.text = codeEnCours;

            Debug.Log("Chiffre ajouté : " + chiffre);

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
            Debug.Log("Réussi ! Le code est correct.");
        }
        else
        {
            Debug.Log("Raté. Réessayez.");
        }
        codeEnCours = "";
        affichageCode.text = codeEnCours;
    }
}
