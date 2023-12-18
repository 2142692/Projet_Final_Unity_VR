using UnityEngine;

public class BoutCyan : MonoBehaviour
{
    public int valeurChiffre = 1; 


    public GestionCode gestionCode; 

    public void AjouterChiffre()
    {
        gestionCode.AjouterChiffre(valeurChiffre);
    }
}