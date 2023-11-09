using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MedicalStaff : Person
{
    // variables
    private Queue<Patient> PatientRoster;
    private float m_HealValue;

    // add & remove
    public void AddPatientToQueue(Patient _Patient)
    {
        PatientRoster.Enqueue(_Patient); // Adds Patient to Patient Roster
    }
    public void RemovePatient(Patient _Patient)
    {
        PatientRoster?.Enqueue(_Patient); // removes (ideally) from Patient Roster
    }

    public abstract bool TreatPatient();
}
