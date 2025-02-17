using System.Collections.Generic;

public static class GameManager
{
    public static List<Unit> PlayerCollection { get; private set; } = new List<Unit>();
    public static Deck PlayerDeck { get; private set; } = new Deck();

    public static void AddUnitToCollection(Unit unit)
    {
        PlayerCollection.Add(unit);
    }

    public static void SaveDeck(Deck deck)
    {
        PlayerDeck = deck;
    }

    public static Deck LoadDeck()
    {
        return PlayerDeck;
    }
}
