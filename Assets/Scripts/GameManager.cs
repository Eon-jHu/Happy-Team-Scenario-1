using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // variables.
    private static GameManager m_GameManager;
    [SerializeField] private Level m_CurrentLevel;
    [SerializeField] private float m_GameTime;
    private float m_TimeRemaining;

    // Singleton Method
    private GameManager()
    {
        m_TimeRemaining = m_GameTime;
        LoadLevel(m_CurrentLevel);
    }

    public GameManager GetInstance()
    {
        if (m_GameManager == null)
        {
            m_GameManager = new GameManager();
        }
        
        return m_GameManager; 
    }

    public void LoadLevel(Level _Level)
    {
        _Level.SetUpLevel();
    }
}
