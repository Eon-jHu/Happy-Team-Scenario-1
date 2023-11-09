using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteLevel : Level
{
    [SerializeField] PatientManager patientManager;
    [SerializeField] HospitalManager hospitalManager;
    [SerializeField] int numStartingNurses;
    [SerializeField] int numStartingDoctors;
    [SerializeField] float patientSpawnTimer;
    float currentPatientSpawnTime;

    public override PatientManager m_PatientManager
    {
        get { return patientManager; } set { patientManager = m_PatientManager; }
    }

    public override HospitalManager m_HospitalManager
    {
        get { return hospitalManager; }  set { hospitalManager = m_HospitalManager; }
    }

    private void Awake()
    {
        Debug.Log("Entering new Level...");
        currentPatientSpawnTime = patientSpawnTimer;

        setUpLevel();
    }

    protected override void setUpLevel()
    {
        GameObject.Instantiate(m_PatientManager);
        GameObject.Instantiate(m_HospitalManager);
    }

    private void Update()
    {
        currentPatientSpawnTime -= Time.deltaTime;
        if (currentPatientSpawnTime <= 0)
        {
            m_PatientManager.spawnPatient();
            currentPatientSpawnTime = patientSpawnTimer;
        }

        patientManager.updatePatients();
        hospitalManager.UpdateStaff();

    }
}
