using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    private void Awake()
    {
        // Initialiser les collections et decks si nécessaire
        if (GameManager.PlayerCollection.Count == 0)
        {
            // Initialiser avec des données de test ou laisser vide pour le début du jeu
            for (int i = 1; i <= 5; i++)
            {
                GameManager.AddUnitToCollection(new Unit { Name = "Unité " + i });
            }
        }
    }
}
