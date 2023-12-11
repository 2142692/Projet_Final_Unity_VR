using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GestionCode : MonoBehaviour
{
    public string codeSouhaite = "RougeJauneMauveVert"; // Le code à deviner
    public TextMeshPro affichageCode; // Le texte où le code est affiché
    public List<string> mots; // Liste de mots à utiliser
    public GameObject carteMagnetic;
    private bool codeCorrect = false;
    private List<string> codeEnCours = new List<string>(); // Le code en cours de saisie

    private int compteurBouton = 0; // Compteur pour suivre les boutons cliqués

    public void AjouterChiffre(int bouton)
    {
        if (codeEnCours.Count < 4)
        {
            string motAjoute = mots[bouton % mots.Count]; // Récupère un mot de la liste en fonction du bouton

            codeEnCours.Add(motAjoute);
            affichageCode.text = string.Join("-", codeEnCours); // Affiche la liste de mots sous forme de texte

            Debug.Log("Mot ajouté : " + motAjoute);

            compteurBouton++; // Incrémente le compteur de bouton

            if (codeEnCours.Count == 4)
            {
                VerifierCode();
            }
        }
        else
        {
            // Réinitialiser le code si un autre bouton est cliqué après avoir terminé
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
            Debug.Log("Réussi ! Le code est correct.");
            carteMagnetic.SetActive(true);
        }
        else
        {
            Debug.Log("Raté. Réessayez.");
        }

        codeEnCours.Clear();
        affichageCode.text = "";
    }
}
