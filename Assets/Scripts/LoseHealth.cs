using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseHealth : Patient
{
    // Start is called before the first frame update
    private float m_patientHealth = 10f;
    private float m_HealthTimer = 0.5f;
    private bool m_NurseNear = false;

    // Update is called once per frame
    void Update()
    {
        m_HealthTimer -= Time.deltaTime;
        if (!m_NurseNear)
        {
            m_patientHealth -= Time.deltaTime;
        }
        else if (m_NurseNear)
        {
            m_patientHealth -= (Time.deltaTime / 4);
        }
        if (m_HealthTimer <= 0)
        {
            if (m_patientHealth < 10f && m_patientHealth > 0)
            {
                Debug.Log("Patient Health is at" + m_patientHealth);
            }
            else if (m_patientHealth <= 0)
            {
                Debug.Log("Patient Died");
                Debug.Log("New Patient Enters");
                m_patientHealth = 10f;
            }
            m_HealthTimer = 0.5f;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (m_NurseNear == true)
            {
                m_NurseNear = false;
                Debug.Log("Nurse No Longer Near, Patient Losing HP Faster");
            }
            else
            {
                m_NurseNear = true;
                Debug.Log("Nurse Near, Patient Losing HP Slower");
            }
        }

    }
}
