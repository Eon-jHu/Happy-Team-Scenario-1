using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteAilmentFactory : AilmentFactory
{
    List<AilmentType> ailmentTypes;
    [SerializeField] GameObject[] symptoms;

    public override Ailment generateAilment()
    {
        // Generates a random Ailment of specified types
        int i = Random.Range(0, (ailmentTypes.Count));

        // Starts the initialization process
        OnStart();

        // Generates a new ailment and returns it
        Ailment ailment = ScriptableObject.CreateInstance<Ailment>();
        ailment.initializeAilment(ailmentTypes[i], (uint)Random.Range(0, 10));

        Debug.Log("Patient has " + ailment.getType());
        return ailment;
    }

    private void OnStart()
    {
        // Gets the array of all AilmentTypes and initializes them
        AilmentType[] ailmentTypeArray = (AilmentType[])System.Enum.GetValues(typeof(AilmentType));
        ailmentTypes = new List<AilmentType>(ailmentTypeArray);
        Debug.Log("Ailment Factory initialized with " + ailmentTypes.Count + " possible Ailments.");
    }
}