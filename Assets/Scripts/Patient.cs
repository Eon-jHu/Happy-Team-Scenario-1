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

    private void Awake()
    {
        Debug.Log("A new patient has arrived at the hospital!");
        m_CurrentSymptomTime = m_SymptomTimer;    
    }

    private void Update()
    {
        m_CurrentSymptomTime -= Time.deltaTime;

        if (m_CurrentSymptomTime <= 0)
        {
            m_CurrentSymptomTime = m_SymptomTimer;
            showASymptom();
        }
    }

    public void setAilment(Ailment _ailment)
    {
        m_Ailment = _ailment;
    }

    public void showASymptom()
    {
        // Randomly apply Ailment penalties based on severity
        // A higher severity has higher chance of ailments being applied
        if (m_Ailment.getSeverity() > Random.Range(1, 10))
        {
            // Deduct HP
            m_Ailment.applyAilmentPenalty(gameObject.GetComponent<Patient>());

            // Plays a random symptom animation from that symptom
            Debug.Log("Patient is showing a symptom!");
            
        }
    }
}
