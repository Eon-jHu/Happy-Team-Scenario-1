using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Person : MonoBehaviour
{
    // variables.
    private Vector2 m_Position;
    private Sprite m_Sprite;

    // setters and getters.
    public Vector2 GetPosition()
    {
        return m_Position;
    }
    
    public void SetPosition(Vector2 _Position)
    {
        m_Position = _Position;
    }

    public void Move()
    {
        // Moves the character
    }

    public Sprite GetSprite()
    {
        return m_Sprite;
    }
}
