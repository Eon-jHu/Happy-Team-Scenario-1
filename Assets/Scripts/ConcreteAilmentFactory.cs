using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteAilmentFactory : AilmentFactory
{
    public override Ailment generateAilment(string _Ailment)
    {
        Ailment ailment = new Ailment(_Ailment);
        return ailment;
    }
}