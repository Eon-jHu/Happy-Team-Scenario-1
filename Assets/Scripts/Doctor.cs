using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctor : MedicalStaff
{
    private enum Specialization
    {
        Common, // Flu, Chicken Pox, Light Injury, Common Cold, Covid
        Surgeon, // Heavy Injury
        Cardiologist, // Heart Attack
        Radiologist, // Pregnant
        Allergist, // Allergies
        Plague_Doctor, // Malaria
        Toxicologist, // Poisoned
        Oncologist // Cancer

    }
    public override bool TreatPatient()
    {
        Debug.Log("Doctor Treating Patient");
        // wait a certain timelength to treat patient
        // if (patient dies)
        // return false
        // else
        return true;
    }
}
