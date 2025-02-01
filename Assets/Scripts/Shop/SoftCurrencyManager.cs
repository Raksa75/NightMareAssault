using UnityEngine;
using UnityEngine.UI;

public class SoftCurrencyManager : MonoBehaviour
{
    public int playerSoftCurrency = 0;
    public Text softCurrencyDisplay;

    private void Start()
    {
        UpdateCurrencyDisplay();
    }

    public void AddCurrency(int amount)
    {
        playerSoftCurrency += amount;
        UpdateCurrencyDisplay();
    }

    private void UpdateCurrencyDisplay()
    {
        softCurrencyDisplay.text = "Coins: " + playerSoftCurrency.ToString();
    }
}


