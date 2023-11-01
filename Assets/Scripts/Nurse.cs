using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Nurse : MedicalStaff
{
    public override bool TreatPatient()
    {
        Debug.Log("Nurse Treating Patient");
        // wait a certain timelength to treat patient
        // if (ailment == really bad)
        // return false
        // else
        return true;
    }
}
