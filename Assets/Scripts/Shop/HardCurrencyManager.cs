using UnityEngine;
using UnityEngine.UI;

public class HardCurrencyManager : MonoBehaviour
{
    public int playerHardCurrency = 0;
    public Text hardCurrencyDisplay;

    private void Start()
    {
        UpdateCurrencyDisplay();
    }

    public void AddCurrency(int amount)
    {
        playerHardCurrency += amount;
        UpdateCurrencyDisplay();
    }

    private void UpdateCurrencyDisplay()
    {
        hardCurrencyDisplay.text = "Gems: " + playerHardCurrency.ToString();
    }
}

