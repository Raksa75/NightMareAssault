using UnityEngine;
using UnityEngine.UI;

public class ManaManager : MonoBehaviour
{
    public int playerMana = 0;
    public Text manaDisplay;
    public int manaIncreaseAmount = 3;
    public float manaIncreaseInterval = 1f;

    private void Start()
    {
        UpdateManaDisplay();
        InvokeRepeating("IncreaseMana", manaIncreaseInterval, manaIncreaseInterval);
    }

    private void IncreaseMana()
    {
        playerMana += manaIncreaseAmount;
        UpdateManaDisplay();
    }

    private void UpdateManaDisplay()
    {
        manaDisplay.text = "Mana: " + playerMana.ToString();
    }
}

