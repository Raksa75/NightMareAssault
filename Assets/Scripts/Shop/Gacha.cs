using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Gacha : MonoBehaviour
{
    public Button generateButton;
    public Text resultText;
    private List<int> allCharacters;
    private DeckBuildingManager deckBuildingManager;

    private void Start()
    {
        generateButton.onClick.AddListener(GenerateRandomCharacters);
        allCharacters = new List<int>();

        // Initialisez la liste des personnages numérotés de 1 à 15
        for (int i = 1; i <= 15; i++)
        {
            allCharacters.Add(i);
        }

        // Trouver le DeckBuildingManager
        deckBuildingManager = FindObjectOfType<DeckBuildingManager>();
    }

    private void GenerateRandomCharacters()
    {
        List<int> randomCharacters = new List<int>();
        List<int> tempCharacters = new List<int>(allCharacters);

        for (int i = 0; i < 10; i++)
        {
            int randomIndex = Random.Range(0, tempCharacters.Count);
            randomCharacters.Add(tempCharacters[randomIndex]);
            tempCharacters.RemoveAt(randomIndex); // Évitez de dupliquer des personnages
        }

        DisplayCharacters(randomCharacters);

        // Ajouter les unités obtenues à la collection du joueur
        foreach (int characterNumber in randomCharacters)
        {
            Unit newUnit = new Unit { Name = "Unité " + characterNumber };
            deckBuildingManager.AddUnitToCollection(newUnit);
        }
    }

    private void DisplayCharacters(List<int> characters)
    {
        resultText.text = "Personnages aléatoires : ";
        foreach (int character in characters)
        {
            resultText.text += character.ToString() + " ";
        }
    }
}
