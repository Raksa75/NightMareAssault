using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    public Button purchaseButton;           // Le bouton pour acheter le personnage
    public Text buttonText;                 // Le texte du bouton (affiche "Acheter" ou "D�j� achet�")
    public SoftCurrencyManager currencyManager; // R�f�rence au gestionnaire des coins
    public int itemCost = 25;               // Co�t du personnage en coins (25 dans cet exemple)
    private bool isItemBought = false;      // V�rifie si l'�l�ment a �t� achet�

    private void Start()
    {
        // Si l'�l�ment a d�j� �t� achet�, mettre � jour l'UI
        if (isItemBought)
        {
            UpdateButtonText();
        }

        // Assigner la fonction de clic sur le bouton d'achat
        purchaseButton.onClick.AddListener(TryBuyItem);

        // Mettre � jour le texte du bouton � chaque d�marrage
        UpdateButtonText();
    }

    // Essayer d'acheter l'�l�ment
    private void TryBuyItem()
    {
        if (!isItemBought) // Si l'�l�ment n'est pas encore achet�
        {
            // Si le joueur a assez de coins, acheter l'�l�ment
            if (currencyManager.playerSoftCurrency >= itemCost)
            {
                currencyManager.playerSoftCurrency -= itemCost;  // D�duire les coins
                isItemBought = true;
                UpdateButtonText(); // Mettre � jour le texte du bouton
            }
            else
            {
                // Afficher un message si les coins sont insuffisants
                Debug.Log("Pas assez de coins pour acheter ce personnage.");
            }
        }
    }

    // Mettre � jour le texte du bouton en fonction de l'�tat d'achat
    private void UpdateButtonText()
    {
        if (isItemBought)
        {
            buttonText.text = "D�j� achet�";
            purchaseButton.interactable = false; // D�sactiver le bouton si l'�l�ment est d�j� achet�
        }
        else
        {
            buttonText.text = "Acheter";
            purchaseButton.interactable = true; // R�activer le bouton si l'�l�ment n'est pas achet�
        }
    }
}
