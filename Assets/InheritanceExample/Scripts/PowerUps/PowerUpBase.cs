using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    // Protected field to store powerup duration
    protected float powerupDuration = 5.0f; // Set your desired duration

    protected abstract void OnHit();


    // Abstract method for powerup activation
    protected abstract void PowerUp();

    // Abstract method for powerup deactivation
    protected abstract void PowerDown();

    // Method to disable powerup visuals and collider
    public void DisablePowerupVisuals()
    {
        // Disable visuals and collider here
        // For example:
        Renderer renderer = GetComponent<Renderer>();
        Collider collider = GetComponent<Collider>();

        if (renderer != null)
            renderer.enabled = false;

        if (collider != null)
            collider.enabled = false;
    }

    // Method to destroy or disable the powerup game object after powerdown
    public void DestroyOrDisablePowerup()
    {
        // Destroy or disable the powerup GameObject
        // For example:
        Destroy(gameObject);
    }
}
