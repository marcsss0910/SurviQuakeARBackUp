using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShaker : MonoBehaviour
{
    private Vector3 originalPosition;
    public float shakeIntensity = 8.5f;
    public float shakeDuration = 20.0f;
    private bool isShaking = false;
    private bool start = false;

    public GameObject camerashake;

    private void Start()
    {
        originalPosition = camerashake.transform.localPosition;
    }

    private void Update()
    {
        if (start && isShaking)
        {
            // Generate random offsets within the specified intensity for X and Y axes
            float offsetX = Random.Range(-shakeIntensity, shakeIntensity);
            float offsetY = Random.Range(-shakeIntensity, shakeIntensity);

            // Apply the offsets to the ARCamera's position
            camerashake.transform.localPosition = originalPosition + new Vector3(offsetX, offsetY, 0);

            // Decrement the shake duration
            shakeDuration -= Time.deltaTime;

            // Check if the shake duration is over
            if (shakeDuration <= 0)
            {
                // Stop shaking and reset the camera position
                camerashake.transform.localPosition = originalPosition;
                isShaking = false;
            }
        }
    }

    public void ClickStart()
    {
        start = true;
        StartCameraShake();
    }

    // Call this method to start the camera shake
    public void StartCameraShake()
    {
        isShaking = true;
        shakeDuration = 20.0f;
    }

    public void PauseCameraShake()
    {
        isShaking = false;
        Debug.Log("PAUSEEEEEEEE");
    }
}
