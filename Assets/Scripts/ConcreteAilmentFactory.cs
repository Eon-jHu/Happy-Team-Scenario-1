using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteAilmentFactory : AilmentFactory
{
    AilmentType[] ailmentTypes;

    public override Ailment generateAilment()
    {
        // Generates a random Ailment of specified types
        int i = Random.Range(0, (ailmentTypes.Length));

        Ailment ailment = new(ailmentTypes[i], (uint)Random.Range(1, 10));
        Debug.Log("Patient has " + ailment.getType());
        return ailment;
    }

    private void Awake()
    {
        // Gets the array of all AilmentTypes
        ailmentTypes = (AilmentType[])System.Enum.GetValues(typeof(AilmentType));
        Debug.Log("Ailment Factory initialized with " + ailmentTypes.Length + " possible Ailments.");
    }
}