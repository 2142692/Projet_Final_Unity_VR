using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GestionCode : MonoBehaviour
{
    public string codeSouhaite = "RougeJauneMauveVert"; // Le code à deviner (de base je voulais chiffre mais j'ai remarqué sa marche comme ça)

    public AudioClip audioClip;
    public AudioClip audioClipRate; //[AUDIO code]


    public AudioClip magneticCard; //[AUDIO magnetic carte tombe]

    public TextMeshPro affichageCode; // Le texte où le code sera affiché
    public List<string> mots; //Liste des mots (sauf 0)

    public GameObject carteMagnetic;
    private bool codeCorrect = false; //De base
    private List<string> codeEnCours = new List<string>(); //Code actuel

    private int compteurBouton = 0; // Compte de bouton click

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
            Debug.Log("Réussi");
            carteMagnetic.SetActive(true);

            GameObject audioObject1 = new GameObject("AudioObject1"); // AudioSource pour réussi
            AudioSource audioSource1 = audioObject1.AddComponent<AudioSource>();
            audioSource1.PlayOneShot(audioClip);
            Destroy(audioObject1, audioClip.length);

            GameObject audioObject2 = new GameObject("AudioObject2"); // Audiosource MagneticCard
            AudioSource audioSource2 = audioObject2.AddComponent<AudioSource>();
            audioSource2.PlayOneShot(magneticCard);
            Destroy(audioObject2, magneticCard.length);
        }
        else
        {
            Debug.Log("Raté.");


            GameObject audioObject = new GameObject("AudioObject"); // Audiosource de rate
            AudioSource audioSource = audioObject.AddComponent<AudioSource>();
            audioSource.PlayOneShot(audioClipRate);
            Destroy(audioObject, audioClipRate.length);
        }

        codeEnCours.Clear();
        affichageCode.text = "";
    }
}
