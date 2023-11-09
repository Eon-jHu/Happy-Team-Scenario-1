using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Level : MonoBehaviour
{
    // Abstract Variables
    public abstract PatientManager m_PatientManager { get; set; }
    public abstract HospitalManager m_HospitalManager { get; set; }

    // funtions.
    protected abstract void setUpLevel();
}
