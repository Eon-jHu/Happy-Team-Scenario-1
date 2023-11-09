using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BudgetManager : MonoBehaviour
{
    [SerializeField] float playerBudget;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player Budget is $" + playerBudget + "!"); // displaying player budget at the start of the game.
    }
    void Update()
    {
        // purchasing a nurse.
        if (Input.GetKeyDown(KeyCode.N))
        {
            playerBudget = (playerBudget - 50.0f);

            Debug.Log("Player purchased a Nurse for $50! Budget is now $" + (playerBudget) + "!");
        }
        // purchasing a doctor.
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerBudget = (playerBudget - 100.0f);

            Debug.Log("Player purchased a Doctor for $100! Budget is now $" + (playerBudget) + "!");
        }
        // firing a nurse.
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerBudget = (playerBudget + 50.0f);
            Debug.Log("Player fired a Nurse and gained $50 back! Budget is now $" + (playerBudget) + "!");
        }
        // firing a doctor.
        if (Input.GetKeyDown(KeyCode.B))
        {
            playerBudget = (playerBudget + 100.0f);
            Debug.Log("Player fired a Doctor and gained $100 back! Budget is now $" + (playerBudget) + "!");
        }
    }
}
