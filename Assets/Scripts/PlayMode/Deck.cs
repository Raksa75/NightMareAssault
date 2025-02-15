using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck
{
    public List<Unit> Units { get; private set; }

    public Deck()
    {
        Units = new List<Unit>();
    }

    public void AddUnit(Unit unit)
    {
        Units.Add(unit);
    }

    public void RemoveUnit(Unit unit)
    {
        Units.Remove(unit);
    }

}
