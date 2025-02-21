using UnityEngine;

public class Lane : MonoBehaviour
{
    public Transform spawnPoint; // Où l'unité va apparaître
    public GameObject unitPrefab; // Prefab de l'unité en jeu

    private void Start()
    {
        if (spawnPoint == null)
        {
            Debug.LogError("❌ Aucun spawnPoint assigné !");
        }
    }

    public void PlaceUnit(UnitData unitData)
    {
        if (unitPrefab == null)
        {
            Debug.LogError("❌ Aucun prefab d'unité assigné à la Lane !");
            return;
        }

        if (spawnPoint == null)
        {
            Debug.LogError("❌ Aucun spawnPoint assigné !");
            return;
        }

        GameObject unitGO = Instantiate(unitPrefab, spawnPoint.position, Quaternion.identity);
        Debug.Log("✅ Unité spawnée : " + unitData.Name + " à " + spawnPoint.position);

        Unit unitComponent = unitGO.GetComponent<Unit>();
        if (unitComponent != null)
        {
            unitComponent.Name = unitData.Name;
        }
        else
        {
            Debug.LogError("❌ Le prefab d'unité ne contient pas de script Unit !");
        }
    }
}
