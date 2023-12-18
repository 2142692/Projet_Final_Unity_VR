using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indiceDistributrice : MonoBehaviour
{
        public GameObject objectToToggle;


        private bool isActive = false;

        public void FadeAndReveal()
        {

            isActive = !isActive; 

            objectToToggle.SetActive(isActive); 
        
    }
}
