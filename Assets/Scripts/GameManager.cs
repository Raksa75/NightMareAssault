public static class GameManager
{
    public static Deck PlayerDeck { get; private set; } = new Deck();

    public static void SaveDeck(Deck deck)
    {
        PlayerDeck = deck;
    }

    public static Deck LoadDeck()
    {
        return PlayerDeck;
    }
}
