using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Gacha : MonoBehaviour
{
    public Button gachaButton;
    public Text resultText;
    private List<UnitData> allUnits;

    private void Start()
    {
        gachaButton.onClick.AddListener(GenerateRandomUnits);
        allUnits = new List<UnitData>();

        // Charge les unités disponibles depuis le dossier Resources
        allUnits.Add(Resources.Load<UnitData>("Units/Chevalier"));
        allUnits.Add(Resources.Load<UnitData>("Units/Archer"));
        allUnits.Add(Resources.Load<UnitData>("Units/Mage"));
    }

    private void GenerateRandomUnits()
    {
        List<UnitData> randomUnits = new List<UnitData>();

        for (int i = 0; i < 10; i++)
        {
            int randomIndex = Random.Range(0, allUnits.Count);
            UnitData randomUnit = allUnits[randomIndex];
            randomUnits.Add(randomUnit);
        }

        DisplayUnits(randomUnits);

        // Ajouter les unités obtenues à la collection du joueur via GameManager
        foreach (UnitData unit in randomUnits)
        {
            GameManager.Instance.AddUnitToCollection(unit);
        }
    }

private void DisplayUnits(List<UnitData> units)
{
    resultText.text = "Personnages obtenus : ";
    foreach (UnitData unit in units)
    {
        resultText.text += unit.Name + " "; // Correction ici
    }
}

}
