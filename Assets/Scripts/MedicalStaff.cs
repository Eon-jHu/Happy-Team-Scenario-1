using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MedicalStaff : Person
{
    // variables
    private Queue<Patient> m_PatientRoster;
    private float m_HealValue;

    // add & remove
    public void AddPatientToQueue(Patient _Patient)
    {
        m_PatientRoster.Enqueue(_Patient); // Adds Patient to Patient Roster
    }
    public void RemovePatient(Patient _Patient)
    {
        m_PatientRoster.Dequeue(); // Removes from Patient Roster
    }

    public abstract bool TreatPatient();
}
