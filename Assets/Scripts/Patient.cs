using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : Person
{
    // variables.
    private float m_Health;

    private Ailment m_ailment;

    // setter and getters.
   public void SetHealth(float _Health)
    {
        m_Health = _Health;
    }

    public void ShowASymptom()
    {
        // showing symptoms.
    }
}
