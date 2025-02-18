using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "SharedData", menuName = "ScriptableObjects/SharedData", order = 1)]
public class SharedData : ScriptableObject
{
    public List<Unit> PlayerCollection = new List<Unit>();
    public Deck PlayerDeck = new Deck();
}
