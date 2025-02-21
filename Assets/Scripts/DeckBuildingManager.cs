using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class DeckBuildingManager : MonoBehaviour
{
    public GameObject unitPrefab; // Prefab UI d'une carte affichée en bas
    public Transform handContainer; // Conteneur UI des cartes en bas
    public int maxHandSize = 3; // Nombre max de cartes affichées en même temps

    private List<UnitData> playerCollection;
    private Deck playerDeck;
    private List<UnitData> currentHand = new List<UnitData>(); // Cartes visibles en bas

    private void Start()
    {
        GameManager.Instance.InitializeCollection();

        playerCollection = GameManager.Instance.PlayerCollection;
        playerDeck = GameManager.Instance.LoadDeck();

        Debug.Log("Unités dans la collection après init : " + playerCollection.Count);

        if (playerDeck.Units.Count == 0)
        {
            Debug.LogWarning("Le deck est vide !");
            return;
        }

        for (int i = 0; i < maxHandSize; i++)
        {
            DrawNewCard();
        }
    }

public void DrawNewCard()
{
    if (playerDeck.Units.Count > 0 && currentHand.Count < maxHandSize)
    {
        UnitData newUnit = playerDeck.Units[0]; // Prend la première unité du deck

        // Vérifier si l'unité est déjà dans la main
        while (currentHand.Contains(newUnit) && playerDeck.Units.Count > 1)
        {
            playerDeck.Units.RemoveAt(0);
            playerDeck.Units.Add(newUnit); // Remet la carte à la fin du deck
            newUnit = playerDeck.Units[0]; // Prend la nouvelle première carte
        }

        playerDeck.Units.RemoveAt(0);
        currentHand.Add(newUnit);
        CreateUnitUI(newUnit, handContainer);
    }
    else
    {
        Debug.LogWarning("Plus de cartes disponibles dans le deck !");
    }
}


    private void CreateUnitUI(UnitData unit, Transform container)
    {
        GameObject unitGO = Instantiate(unitPrefab, container);
        Debug.Log("Carte affichée en main : " + unit.Name);

        Text unitText = unitGO.GetComponentInChildren<Text>();
        if (unitText != null)
        {
            unitText.text = unit.Name;
        }
    }

    public void RemoveCardFromHand(UnitData unit)
    {
        currentHand.Remove(unit);
        DrawNewCard();
    }
}
