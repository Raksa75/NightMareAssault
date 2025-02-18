using UnityEngine;
using UnityEngine.UI;

public class HardCurrencyManager : MonoBehaviour
{
    public int playerHardCurrency = 0;  // Nombre de gemmes du joueur
    public Text hardCurrencyDisplay;     // Affichage du nombre de gemmes

    private void Start()
    {
        UpdateCurrencyDisplay();          // Met � jour l'affichage des gemmes au d�marrage
    }

    // Ajoute des gemmes
    public void AddCurrency(int amount)
    {
        playerHardCurrency += amount;
        UpdateCurrencyDisplay(); // Met � jour l'affichage apr�s avoir ajout� des gemmes
    }

    // V�rifie si le joueur a assez de gemmes
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
            UpdateCurrencyDisplay(); // Met � jour l'affichage apr�s consommation
        }
    }

    // Met � jour l'affichage des gemmes
    private void UpdateCurrencyDisplay()
    {
        hardCurrencyDisplay.text = "Gems: " + playerHardCurrency.ToString();
    }
}
