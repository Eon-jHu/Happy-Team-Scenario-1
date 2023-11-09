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

        if (m_CurrentSymptomTime <= 0)
        {
            m_CurrentSymptomTime = m_SymptomTimer;
            ShowASymptom();
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
}
