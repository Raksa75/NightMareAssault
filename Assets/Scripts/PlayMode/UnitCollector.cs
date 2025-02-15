using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitCollector : MonoBehaviour
{
    public Deck PlayerDeck;

    private void Start()
    {
        PlayerDeck = new Deck();
    }
    
    public void CollectUnit(Unit unit)
    {
        PlayerDeck.AddUnit(unit);
        Debug.Log("New Card in deck");
    }

}
