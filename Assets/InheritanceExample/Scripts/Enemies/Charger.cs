using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : EnemyBase
{
    private Vector3 deathLocation; // Define the death location variable
    [SerializeField] private GameObject objectToSpawn;
    protected override void OnHit()
    {
        Debug.Log("This is a log message");
        //increase speed when hit
        MoveSpeed *= 2;
    }
    //when charger does you spawn the powerUp

    public override void Kill()
    {
        AudioHelper.PlayClip2D(_deathSound, 1, .1f);
        gameObject.SetActive(false);
        //sets up death location
        deathLocation = transform.position;
        // Instantiate RapidFirePowerup at the death location
        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
    }

}
