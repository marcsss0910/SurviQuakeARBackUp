using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public CameraShaker cameraShaker; // Reference to the CameraShaker script
    public SpawnObjects spawnObjects; // Reference to the SpawnObject script

    private void Start()
    {
        // Ensure that the cameraShaker reference is set in the Inspector
        if (cameraShaker == null)
        {
            Debug.LogError("CameraShaker reference is not set. Please assign the CameraShaker script in the Inspector.");
        }
        if (spawnObjects == null)
        {
            Debug.LogError("SpawnObjects reference is not set. Please assign the SpawnObjects script in the Inspector.");
        }
    }

    public void OnButtonClick()
    {
        // Call the StartCameraShake method to trigger the camera shake
        cameraShaker.ClickStart();
        spawnObjects.ClickStart();

    }
}

