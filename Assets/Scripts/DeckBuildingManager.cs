public class DeckBuildingManager : MonoBehaviour
{
    public GameObject unitPrefab;
    public Transform collectionContainer;
    public Transform deckContainer;

    private List<Unit> playerCollection;
    private Deck playerDeck;

    private void Start()
    {
        playerCollection = GameManager.PlayerCollection;
        playerDeck = GameManager.LoadDeck();

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

    private void OnDisable()
    {
        GameManager.SaveDeck(playerDeck);
    }
}
