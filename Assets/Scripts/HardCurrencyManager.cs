using UnityEngine;
using UnityEngine.UI;

public class HardCurrencyManager : MonoBehaviour
{
    public int playerHardCurrency = 0;  // Nombre de gemmes du joueur
    public Text hardCurrencyDisplay;     // Affichage du nombre de gemmes

    private void Start()
    {
        UpdateCurrencyDisplay();          // Met à jour l'affichage des gemmes au démarrage
    }

    // Ajoute des gemmes
    public void AddCurrency(int amount)
    {
        playerHardCurrency += amount;
        UpdateCurrencyDisplay(); // Met à jour l'affichage après avoir ajouté des gemmes
    }

    // Vérifie si le joueur a assez de gemmes
    public bool HasEnoughCurrency(int requiredAmount)
    {
        return playerHardCurrency >= requiredAmount;
    }

    // Consomme les gemmes lorsque le joueur lance le gacha
    public void ConsumeCurrency(int amount)
    {
        if (playerHardCurrency >= amount)
        {
            playerHardCurrency -= amount;
            UpdateCurrencyDisplay(); // Met à jour l'affichage après consommation
        }
    }

    // Met à jour l'affichage des gemmes
    private void UpdateCurrencyDisplay()
    {
        hardCurrencyDisplay.text = "Gems: " + playerHardCurrency.ToString();
    }
}
