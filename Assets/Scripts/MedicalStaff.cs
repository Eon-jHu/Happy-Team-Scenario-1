using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MedicalStaff : Person
{
    //private Queue<Patient> PatientRoster;
    private float m_HealValue;

    //public void AddPatientToQueue(Patient)
    //{

    //}
    //public void RemovePatient(Patient)
    //{

    //}

    public abstract bool TreatPatient();
}
