using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GestionCodeOrdi : MonoBehaviour
{
    public string codeSouhaite = "8142"; // Le code
    public TextMeshPro affichageCode; 
    public Material nouvelleTextureRate; 
    public Material nouvelleTextureReussi; 
    public GameObject objetAChangerTexture; 
    
    private string codeEnCours = ""; 
    private Material materialInitial; 

    public GameObject[] ActivateMenuScreen;
    public GameObject[] DeactivateMenuScreen;
    void Start()
    {
        
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

            
            StartCoroutine(ChangerTexturePendantDuree(nouvelleTextureRate, 2f));
            codeEnCours = "";
        }
    }

    private IEnumerator ChangerTexturePendantDuree(Material nouvelleTextureRate, float duree)
    {
        // texture anim
        objetAChangerTexture.GetComponent<Renderer>().material = nouvelleTextureRate;

        
        yield return new WaitForSeconds(duree);

        
        objetAChangerTexture.GetComponent<Renderer>().material = materialInitial;
    }

    
}