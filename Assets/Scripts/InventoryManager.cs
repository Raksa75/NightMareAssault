using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    // Liste des unités
    private List<string> units;

    private void Awake()
    {
        // Charger l'inventaire sauvegardé depuis PlayerPrefs
        LoadInventory();
    }

    private void LoadInventory()
    {
        // Vérifier si des unités ont été sauvegardées
        if (PlayerPrefs.HasKey("Units"))
        {
            string unitsData = PlayerPrefs.GetString("Units");
            units = new List<string>(unitsData.Split(','));
        }
        else
        {
            units = new List<string>();
        }
    }

    private void SaveInventory()
    {
        // Sauvegarder l'inventaire sous forme de string
        PlayerPrefs.SetString("Units", string.Join(",", units));
        PlayerPrefs.Save();
    }

    public void AddUnit(string unitName)
    {
        units.Add(unitName);
        SaveInventory();
    }

    public List<string> GetUnits()
    {
        return units;
    }
}
