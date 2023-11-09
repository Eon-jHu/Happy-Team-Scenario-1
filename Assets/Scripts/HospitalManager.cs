using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HospitalManager : MonoBehaviour
{
    List<MedicalStaff> m_medicalStaff;
    [SerializeField] SpriteRenderer m_spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // Instantiates how many of each doctor and nurse based on level
        Debug.Log("Hospital Manager initialized.");
    }

    public void UpdateStaff()
    {
        Debug.Log("Hospital Staff are moving and updating...");
    }
}
