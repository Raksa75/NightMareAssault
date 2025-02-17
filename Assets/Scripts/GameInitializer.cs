using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    private void Awake()
    {
        // Initialiser les collections et decks si n�cessaire
        if (GameManager.PlayerCollection.Count == 0)
        {
            // Initialiser avec des donn�es de test ou laisser vide pour le d�but du jeu
            for (int i = 1; i <= 5; i++)
            {
                GameManager.AddUnitToCollection(new Unit { Name = "Unit� " + i });
            }
        }
    }
}
