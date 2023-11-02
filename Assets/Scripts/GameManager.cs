using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // variables.
    private static GameManager m_GameManager; // is this supposed to be a pointer?
    private Level m_CurrentLevel;
    private float m_GameTime;
    private float m_TimeRemaining;

    // functions.
    public GameManager()
    {
        // constructor.
    }

    public void LoadLevel(Level _Level)
    {
        _Level.SetUpLevel(); // set up that level G.
    }
}
