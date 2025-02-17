using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class DeckBuildingManager : MonoBehaviour
{
    public GameObject unitPrefab; // Le prefab de l'unité pour l'UI
    public Transform collectionContainer; // Le conteneur de la collection
    public Transform deckContainer; // Le conteneur du deck

    private List<Unit> playerCollection;
    private Deck playerDeck;

    private void Start()
    {
        // Initialisez la collection et le deck
        playerCollection = GetPlayerCollection();
        playerDeck = new Deck();

        // Affichez la collection d'unités
        foreach (Unit unit in playerCollection)
        {
            GameObject unitGO = Instantiate(unitPrefab, collectionContainer);
            unitGO.GetComponentInChildren<Text>().text = unit.Name;
            unitGO.GetComponent<UnitDragHandler>().Setup(unit, this);
        }
    }

    public void AddUnitToCollection(Unit unit)
    {
        playerCollection.Add(unit);
        GameObject unitGO = Instantiate(unitPrefab, collectionContainer);
        unitGO.GetComponentInChildren<Text>().text = unit.Name;
        unitGO.GetComponent<UnitDragHandler>().Setup(unit, this);
    }

    public void AddUnitToDeck(Unit unit)
    {
        playerDeck.AddUnit(unit);
        GameObject unitGO = Instantiate(unitPrefab, deckContainer);
        unitGO.GetComponentInChildren<Text>().text = unit.Name;
        unitGO.GetComponent<UnitDragHandler>().Setup(unit, this);
    }

    private List<Unit> GetPlayerCollection()
    {
        // Simulez une collection de test
        List<Unit> collection = new List<Unit>();
        for (int i = 1; i <= 15; i++)
        {
            collection.Add(new Unit { Name = "Unité " + i });
        }
        return collection;
    }
}
