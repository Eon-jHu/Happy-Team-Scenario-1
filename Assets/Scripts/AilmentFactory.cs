using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AilmentFactory : MonoBehaviour
{
    public abstract Ailment generateAilment();
}