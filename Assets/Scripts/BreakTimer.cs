using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakTimer : MonoBehaviour
{
    private float originalTimer = 5f;
    private float breakTimer = 10f;
    private bool isBreakTime = false;

    void Update()
    {
        // if NPC is on break.
        if (isBreakTime)
        {
            breakTimer -= Time.deltaTime; // decrement break timer.

            if (breakTimer <= 0f)
            {
                Debug.Log("NPC break is over!");
                isBreakTime = false;
                originalTimer = 5f; // reset original timer for the next break.
            }
        }
        else
        {
            originalTimer -= Time.deltaTime; // decrement original timer.

            if (originalTimer <= 0f)
            {
                Debug.Log("NPC is taking a break!");
                isBreakTime = true;
                breakTimer = 10f; // set the break timer until NPC works again.
            }
        }
    }
}
