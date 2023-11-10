using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Symptom : MonoBehaviour
{
    private string symptomName;

    public abstract Animation getSymptomAnimation();
}