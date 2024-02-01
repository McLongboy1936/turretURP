using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFirePowerup : PowerUpBase
{
   protected override void OnHit()
    {
        Debug.Log("Power Up is hit.");
        // Call the abstract PowerUp method
        PowerUp();

        // Disable powerup visuals and collider
        DisablePowerupVisuals();

        // Invoke the PowerDown method after the specified duration
        Invoke("PowerDown", powerupDuration);

    }

    private void OnTriggerEnter(Collider other)
    {
        Projectile projectile = other.GetComponent<Projectile>();
        if (projectile != null)
        {
     
            OnHit();

        }
    }
    // Reference to the TurretController (you can use FindObjectOfType for simplicity)
    private TurretController turretController;

    private void Start()
    {
        // Find the TurretController in the scene
        turretController = FindObjectOfType<TurretController>();
    }

    // Override the PowerUp method
    protected override void PowerUp()
    {
        // Check if TurretController is found
        if (turretController != null)
        {
            // Reduce the Shot cooldown by half
            turretController.ReduceShotCooldown(0.5f);
        }
    }

    // Override the PowerDown method
    protected override void PowerDown()
    {
        // Check if TurretController is found
        if (turretController != null)
        {
            // Return Shot Cooldown to the original duration
            turretController.ResetShotCooldown();
        }

        // Destroy or disable the powerup GameObject
        DestroyOrDisablePowerup();
    }

   
}