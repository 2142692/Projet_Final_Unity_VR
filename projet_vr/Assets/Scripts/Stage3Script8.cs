using UnityEngine;

public class Stage3Script8 : MonoBehaviour
{
    public int valeurChiffre = 8;
    public GestionCodeOrdi gestionCode; 

    
    public void ActionAPartirDuBoutonUI()
    {
       
        if (gestionCode != null)
        {
           
            gestionCode.AjouterChiffre(valeurChiffre);
        }
        else
        {
            Debug.LogError("Script GestionCodeOrdi non assigné !");
        }
    }
}