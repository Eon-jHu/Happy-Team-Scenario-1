using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientManager : MonoBehaviour
{
    private List<Patient> m_ActivePatients;
    [SerializeField] Patient m_PatientPrefab;
    [SerializeField] AilmentFactory m_AilmentFactory;

    private void Awake()
    {
        Debug.Log("Patient Manager initialized.");
        m_AilmentFactory = Instantiate(m_AilmentFactory);
    }

    // Spawns a new patient into the game
    public Patient spawnPatient()
    {
        Patient newPatient = GameObject.Instantiate(m_PatientPrefab);
        newPatient.setAilment(m_AilmentFactory.generateAilment());
        m_ActivePatients.Add(newPatient);
        return newPatient;
    }

    public void updatePatients()
    {
        Debug.Log("Patients are moving and updating...");
    }
}
