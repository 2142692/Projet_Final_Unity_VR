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
    public AudioClip audioClip;
    public AudioClip audioClipRate;

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
            GameObject audioObject = new GameObject("AudioObject"); // Audiosource de réussi
            AudioSource audioSource = audioObject.AddComponent<AudioSource>();
            audioSource.PlayOneShot(audioClip); 
            Destroy(audioObject, audioClip.length); //Pense pas que ce soit nécessaire mais j'ai copier collé de rate pis sa marche alors je préfères pas y toucher


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
            GameObject audioObject = new GameObject("AudioObject"); // recrée GameObject pour l'audioObject
            AudioSource audioSource = audioObject.AddComponent<AudioSource>();
            audioSource.PlayOneShot(audioClipRate); 
            Destroy(audioObject, audioClipRate.length); //Detruit pour laisser la chance de le rejouer si le code est encore raté


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