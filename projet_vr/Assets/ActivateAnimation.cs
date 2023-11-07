using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAnimation : MonoBehaviour
{
    public AnimateMesh animateMeshScript; // Référence au script AnimateMesh

    private void Start()
    {
        // Assurez-vous que vous avez référencé le script AnimateMesh dans l'inspector Unity
        if (animateMeshScript == null)
        {
            Debug.LogError("Veuillez assigner le script AnimateMesh dans l'inspecteur.");
        }
    }

    private void Update()
    {
        // Vous pouvez activer l'animation en appelant la méthode StartAnimation du script AnimateMesh
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animateMeshScript.StartAnimation();
        }
    }
}
