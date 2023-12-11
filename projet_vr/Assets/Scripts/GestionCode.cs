using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GestionCode : MonoBehaviour
{
    public string codeSouhaite = "RougeJauneMauveVert"; // Le code � deviner
    public TextMeshPro affichageCode; // Le texte o� le code est affich�
    public List<string> mots; // Liste de mots � utiliser
    public GameObject carteMagnetic;
    private bool codeCorrect = false;
    private List<string> codeEnCours = new List<string>(); // Le code en cours de saisie

    private int compteurBouton = 0; // Compteur pour suivre les boutons cliqu�s

    public void AjouterChiffre(int bouton)
    {
        if (codeEnCours.Count < 4)
        {
            string motAjoute = mots[bouton % mots.Count]; // R�cup�re un mot de la liste en fonction du bouton

            codeEnCours.Add(motAjoute);
            affichageCode.text = string.Join("-", codeEnCours); // Affiche la liste de mots sous forme de texte

            Debug.Log("Mot ajout� : " + motAjoute);

            compteurBouton++; // Incr�mente le compteur de bouton

            if (codeEnCours.Count == 4)
            {
                VerifierCode();
            }
        }
        else
        {
            // R�initialiser le code si un autre bouton est cliqu� apr�s avoir termin�
            codeEnCours.Clear();
            compteurBouton = 0;
            affichageCode.text = "";
        }
    }

    private void VerifierCode()
    {
        string codeString = string.Join("", codeEnCours); // Convertit la liste de chiffres en un seul texte

        if (codeString == codeSouhaite)
        {
            Debug.Log("R�ussi ! Le code est correct.");
            carteMagnetic.SetActive(true);
        }
        else
        {
            Debug.Log("Rat�. R�essayez.");
        }

        codeEnCours.Clear();
        affichageCode.text = "";
    }
}
