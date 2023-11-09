using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

enum AilmentType
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
    //Oncologist
    cancer

}

public class Ailment
{
    public Ailment(string _Name)
    {
        m_ailmentName = _Name;
    }

    private AilmentType m_ailmentType;
    private string m_ailmentName;
    private List<Symptom> m_symptom;
    private uint severity;

    public uint getSeverity()
    {
        return severity;
    }

    public void applyAilmentPenalty()
    {

    }
}