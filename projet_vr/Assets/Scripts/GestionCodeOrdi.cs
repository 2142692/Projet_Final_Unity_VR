using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GestionCodeOrdi : MonoBehaviour
{
    public string codeSouhaite = "8142"; // Le code � deviner
    public TextMeshPro affichageCode; // Le texte o� le code est affich�
    public Material nouvelleTextureRate; // La nouvelle texture � appliquer en cas d'�chec
    public Material nouvelleTextureReussi; // La nouvelle texture � appliquer en cas de r�ussite
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

            foreach (GameObject obj in ActivateMenuScreen)
            {
                obj.SetActive(true);
            }

            // D�sactiver les objets
            foreach (GameObject obj in DeactivateMenuScreen)
            {
                obj.SetActive(false);
            }
        }
        else
        {
            Debug.Log("Rat�. R�essayez.");

            // Lance la coroutine pour changer la texture et la remettre � l'initiale apr�s un d�lai
            StartCoroutine(ChangerTexturePendantDuree(nouvelleTextureRate, 2f));
            codeEnCours = "";
        }
    }

    private IEnumerator ChangerTexturePendantDuree(Material nouvelleTextureRate, float duree)
    {
        // Change la texture de l'objet
        objetAChangerTexture.GetComponent<Renderer>().material = nouvelleTextureRate;

        // Attend le d�lai sp�cifi�
        yield return new WaitForSeconds(duree);

        // Remet la texture initiale apr�s le d�lai
        objetAChangerTexture.GetComponent<Renderer>().material = materialInitial;
    }

    
}