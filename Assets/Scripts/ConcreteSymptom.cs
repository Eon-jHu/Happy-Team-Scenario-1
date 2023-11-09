using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteSymptom : Symptom
{
    public override Animation getSymptomAnimation()
    {
        Debug.Log("Patient is displaying a Symptom Animation");
        return null;
    }
}