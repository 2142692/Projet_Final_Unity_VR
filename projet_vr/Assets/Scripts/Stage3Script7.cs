using UnityEngine;

public class Stage3Script7 : MonoBehaviour
{
    public int valeurChiffre = 7;
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