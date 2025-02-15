using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Gacha : MonoBehaviour
{
    public Button generateButton;
    public Text resultText;
    private List<int> allCharacters;

    private void Start()
    {
        generateButton.onClick.AddListener(GenerateRandomCharacters);
        allCharacters = new List<int>();

        for (int i = 1; i <= 15; i++)
        {
            allCharacters.Add(i);
        }
    }

    private void GenerateRandomCharacters()
    {
        List<int> randomCharacters = new List<int>();
        List<int> tempCharacters = new List<int>(allCharacters);

        for (int i = 0; i < 10; i++)
        {
            int randomIndex = Random.Range(0, tempCharacters.Count);
            randomCharacters.Add(tempCharacters[randomIndex]);
        }

        DisplayCharacters(randomCharacters);
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

