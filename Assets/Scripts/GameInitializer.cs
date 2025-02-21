using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    private void Awake()
    {
        // Initialiser les collections et decks si nécessaire
        if (GameManager.Instance.PlayerCollection.Count == 0)
        {
            Debug.Log("Ajout d'unités de test à la collection !");
            GameManager.Instance.AddUnitToCollection(Resources.Load<UnitData>("Units/Chevalier"));
            GameManager.Instance.AddUnitToCollection(Resources.Load<UnitData>("Units/Archer"));
            GameManager.Instance.AddUnitToCollection(Resources.Load<UnitData>("Units/Mage"));
        }
    }
}
