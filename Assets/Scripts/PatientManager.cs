using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientManager
{
    private List<Patient> m_ActivePatients;
    private AilmentFactory m_AilmentFactory;

    public Patient SpawnPatient()
    {
        return new Patient(); // making a new patient?
    }

    public void UpdatePatients()
    {
        Debug.Log("Number of patients = " + m_ActivePatients.Count);
        // update number of patients?
    }
}
