using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : Person
{
    // variables.
    private float m_Health;
    
    // ailment: Ailment.

    // setter and getters.
   public void SetHealth(float _Health)
    {
        m_Health = _Health;
    }

    public void ShowASymtpom()
    {
        // showing symptoms.
    }
}
