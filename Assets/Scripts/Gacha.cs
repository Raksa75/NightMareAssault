using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Gacha : MonoBehaviour
{
    public Button gachaButton;
    public Text resultText;
    private List<Unit> allUnits;

    private void Start()
    {
        gachaButton.onClick.AddListener(GenerateRandomUnits);
        allUnits = new List<Unit>();

        // Initialisez la liste des personnages num�rot�s de 1 � 15
        for (int i = 1; i <= 15; i++)
        {
            allUnits.Add(new Unit { Name = "Unit� " + i });
        }
    }

    private void GenerateRandomUnits()
    {
        List<Unit> randomUnits = new List<Unit>();

        for (int i = 0; i < 10; i++)
        {
            int randomIndex = Random.Range(0, allUnits.Count);
            Unit randomUnit = new Unit { Name = allUnits[randomIndex].Name };
            randomUnits.Add(randomUnit);
        }

        DisplayUnits(randomUnits);

        // Ajouter les unit�s obtenues � la collection du joueur via GameManager
        foreach (Unit unit in randomUnits)
        {
            GameManager.AddUnitToCollection(unit);
        }
    }

    private void DisplayUnits(List<Unit> units)
    {
        resultText.text = "Personnages obtenus : ";
        foreach (Unit unit in units)
        {
            resultText.text += unit.Name + " ";
        }
    }
}
