using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : EnemyBase
{
    private float originalMoveSpeed = 0.05f;
    IEnumerator resumeAfterDelay()
    {
        // Wait for 1 second
        yield return new WaitForSeconds(1f);



        // Reset the movement speed to the original speed
        MoveSpeed = originalMoveSpeed;

    }
    protected override void OnHit()
    {
        MoveSpeed = 0;
        StartCoroutine(resumeAfterDelay());


    }

}


