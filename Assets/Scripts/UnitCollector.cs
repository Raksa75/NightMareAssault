using UnityEngine;

public class UnitCollector : MonoBehaviour
{
    public Deck PlayerDeck;

    private void Start()
    {
        PlayerDeck = new Deck();
    }
    
public void CollectUnit(UnitData unit)
{
    PlayerDeck.AddUnit(unit);
    Debug.Log("New Card in deck: " + unit.Name); // Correction ici
}

}
