using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctor : MedicalStaff
{
    private enum Specialization
    {
        Common, // flu, chicken pox, light injury, common cold, covid
        Surgeon, // heavy injury
        Cardiologist, // heart attack
        Radiologist, // pregnant
        Allergist, // allergies
        Plague_Doctor, // malaria
        Toxicologist, // poisoned
        Oncologist // cancer

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
