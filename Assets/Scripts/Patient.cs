using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : Person
{
    // Variables
    public float m_Health
    {
        get; set;
    }

    public bool m_nurseNear = false;

    private Ailment m_Ailment;

    [SerializeField] private float m_SymptomTimer;
    private float m_CurrentSymptomTime;

    private void Start()
    {
        m_CurrentSymptomTime = m_SymptomTimer;    
    }

    private void Update()
    {
        m_CurrentSymptomTime -= Time.deltaTime;

        if (!m_nurseNear)
        {
            m_Health -= Time.deltaTime;
        }
        else
        {
            m_Health -= (Time.deltaTime / 3);
        }
        if (m_CurrentSymptomTime <= 0)
        {
            m_CurrentSymptomTime = m_SymptomTimer;
            ShowASymptom();
        }

        if (m_Health == 9 || m_Health == 8 || m_Health == 7 || m_Health == 6 || m_Health == 5 || m_Health == 4 || m_Health == 3 || m_Health == 2 || m_Health == 1)
        {
            Debug.Log("Health at " + m_Health);
        }
        if (m_Health <= 0)
        {
            Debug.Log("Patient Died");
        }
    }

    public void ShowASymptom()
    {
        // Display symptom animations
        foreach(Symptom symptom in m_Ailment.getSymptoms())
        {
            symptom.getSymptomAnimation();
        }

        // Randomly apply Ailment penalties based on severity
        // A higher severity has higher chance of ailments being applied
        if (m_Ailment.getSeverity() > Random.Range(1, 10))
        {
            m_Ailment.applyAilmentPenalty(gameObject.GetComponent<Patient>());
        }

        m_Ailment.getSeverity();
    }

    public bool IsNurseClose()
    {
        for (int i = 0; i < m_NurseAmount; i++)
        {
            if (GetPosition() - Nurse.GetPosition() <= 10)
            {
                return true;
            }
        }
        return false;
    }
}
