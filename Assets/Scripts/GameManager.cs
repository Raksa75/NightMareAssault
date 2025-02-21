using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private List<UnitData> startingDeck; // Deck modifiable depuis l'Inspector
    public List<UnitData> PlayerCollection { get; private set; } = new List<UnitData>();
    public Deck PlayerDeck { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
        InitializeCollection();
        InitializeDeck();
    }

    public void AddUnitToCollection(UnitData unit)
    {
        if (unit != null)
        {
            PlayerCollection.Add(unit);
        }
        else
        {
            Debug.LogError("Tentative d'ajouter une unité NULL à la collection !");
        }
    }

    public void SaveDeck(Deck deck)
    {
        PlayerDeck = deck;
    }

    public Deck LoadDeck()
    {
        return PlayerDeck;
    }

    public void InitializeCollection()
    {
        if (PlayerCollection.Count == 0)
        {
            Debug.Log("Ajout d'unités de test à la collection !");
            PlayerCollection.Add(Resources.Load<UnitData>("Units/Chevalier"));
            PlayerCollection.Add(Resources.Load<UnitData>("Units/Archer"));
            PlayerCollection.Add(Resources.Load<UnitData>("Units/Mage"));
        }
    }

    public void InitializeDeck()
    {
        PlayerDeck = new Deck();

        if (startingDeck != null && startingDeck.Count > 0)
        {
            Debug.Log("Chargement du deck depuis l'Inspector.");
            foreach (UnitData unit in startingDeck)
            {
                PlayerDeck.AddUnit(unit);
            }
        }
        else
        {
            Debug.LogWarning("⚠️ Aucun deck configuré dans l'Inspector. Utilisation d'un deck par défaut.");
            PlayerDeck.AddUnit(Resources.Load<UnitData>("Units/Chevalier"));
            PlayerDeck.AddUnit(Resources.Load<UnitData>("Units/Archer"));
            PlayerDeck.AddUnit(Resources.Load<UnitData>("Units/Mage"));
        }
    }
}
