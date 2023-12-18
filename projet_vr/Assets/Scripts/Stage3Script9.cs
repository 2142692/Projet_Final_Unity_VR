using UnityEngine;

public class Stage3Script9 : MonoBehaviour
{
    public int valeurChiffre = 9;
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