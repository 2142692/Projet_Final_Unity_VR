using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateMesh : MonoBehaviour
{
    public float speed = 2.0f; // Vitesse de mont�e en m�tres par seconde
    public float distance = 4.0f; // Distance de mont�e en m�tres

    private Vector3 initialPosition;
    private Vector3 targetPosition;
    private float startTime;
    private bool isAnimating = false; // Variable pour contr�ler l'animation

    private void Start()
    {
        initialPosition = transform.position;
        targetPosition = initialPosition + Vector3.up * distance;
        startTime = Time.time;
    }

    private void Update()
    {
        if (isAnimating)
        {
            float journeyLength = Vector3.Distance(initialPosition, targetPosition);
            float journeyTime = journeyLength / speed;
            float journeyFraction = (Time.time - startTime) / journeyTime;

            if (journeyFraction < 1.0f)
            {
                // Interpolez la position du mesh pour le faire monter
                transform.position = Vector3.Lerp(initialPosition, targetPosition, journeyFraction);
            }
            else
            {
                // L'animation est termin�e, faites ce que vous voulez ici
                isAnimating = false;
            }
        }
    }

    public void StartAnimation()
    {
        isAnimating = true;
    }
}
