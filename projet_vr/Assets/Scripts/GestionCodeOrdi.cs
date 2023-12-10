using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GestionCodeOrdi : MonoBehaviour
{
    public string codeSouhaite = "8142"; // Le code à deviner
    public TextMeshPro affichageCode; // Le texte où le code est affiché
    public Material nouvelleTextureRate; // La nouvelle texture à appliquer en cas d'échec
    public Material nouvelleTextureReussi; // La nouvelle texture à appliquer en cas de réussite
    public GameObject objetAChangerTexture; // L'objet dont vous voulez changer la texture
    
    private string codeEnCours = ""; // Le code en cours de saisie
    private Material materialInitial; // Pour stocker la texture initiale

    public GameObject[] ActivateMenuScreen;
    public GameObject[] DeactivateMenuScreen;
    void Start()
    {
        // Sauvegarde la texture initiale de l'objet
        materialInitial = objetAChangerTexture.GetComponent<Renderer>().material;
    }

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

            foreach (GameObject obj in ActivateMenuScreen)
            {
                obj.SetActive(true);
            }

            // Désactiver les objets
            foreach (GameObject obj in DeactivateMenuScreen)
            {
                obj.SetActive(false);
            }
        }
        else
        {
            Debug.Log("Raté. Réessayez.");

            // Lance la coroutine pour changer la texture et la remettre à l'initiale après un délai
            StartCoroutine(ChangerTexturePendantDuree(nouvelleTextureRate, 2f));
            codeEnCours = "";
        }
    }

    private IEnumerator ChangerTexturePendantDuree(Material nouvelleTextureRate, float duree)
    {
        // Change la texture de l'objet
        objetAChangerTexture.GetComponent<Renderer>().material = nouvelleTextureRate;

        // Attend le délai spécifié
        yield return new WaitForSeconds(duree);

        // Remet la texture initiale après le délai
        objetAChangerTexture.GetComponent<Renderer>().material = materialInitial;
    }

    
}