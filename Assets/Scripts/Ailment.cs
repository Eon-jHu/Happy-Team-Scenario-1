using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public enum AilmentType
{
    // Common
    flu, 
    chicken_pox, 
    light_injury, 
    common_cold, 
    covid,
    // Surgeon
    heavy_injury,
    // Cardiologist
    heart_attack,
    // Radiologist
    pregnant,
    //Allergist
    allergies,
    // Plague_Doctor
    malaria,
    // Toxicologist
    poisoned,
    // Oncologist
    cancer,
}

public class Ailment
{
    public Ailment(AilmentType _type, uint _severity)
    {
        m_ailmentType = _type;
        m_severity = _severity;
        m_ailmentName = m_ailmentType.ToString();
    }

    private AilmentType m_ailmentType;
    private string m_ailmentName;
    private List<Symptom> m_symptoms;
    private uint m_severity;

    public uint getSeverity()
    {
        return m_severity;
    }

    public AilmentType getType()
    {
        return m_ailmentType;
    }

    public List<Symptom> getSymptoms()
    {
        return m_symptoms;
    }

    public void applyAilmentPenalty(Patient _patient)
    {
        Debug.Log("Patient's health is being deducted!");
        _patient.m_Health -= m_severity;
    }
}