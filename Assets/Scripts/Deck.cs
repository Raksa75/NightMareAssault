using System.Collections.Generic;
using UnityEngine;

public class Deck
{
    public List<UnitData> Units { get; private set; }

    public Deck()
    {
        Units = new List<UnitData>();
    }

    public void AddUnit(UnitData unit)
    {
        Units.Add(unit);
    }

    public void RemoveUnit(UnitData unit)
    {
        Units.Remove(unit);
    }
}
