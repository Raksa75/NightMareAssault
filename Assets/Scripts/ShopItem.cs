using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    public Button purchaseButton;           // Le bouton pour acheter le personnage
    public Text buttonText;                 // Le texte du bouton (affiche "Acheter" ou "Déjà acheté")
    public SoftCurrencyManager currencyManager; // Référence au gestionnaire des coins
    public int itemCost = 25;               // Coût du personnage en coins (25 dans cet exemple)
    private bool isItemBought = false;      // Vérifie si l'élément a été acheté

    private void Start()
    {
        // Si l'élément a déjà été acheté, mettre à jour l'UI
        if (isItemBought)
        {
            UpdateButtonText();
        }

        // Assigner la fonction de clic sur le bouton d'achat
        purchaseButton.onClick.AddListener(TryBuyItem);

        // Mettre à jour le texte du bouton à chaque démarrage
        UpdateButtonText();
    }

    // Essayer d'acheter l'élément
    private void TryBuyItem()
    {
        if (!isItemBought) // Si l'élément n'est pas encore acheté
        {
            // Si le joueur a assez de coins, acheter l'élément
            if (currencyManager.playerSoftCurrency >= itemCost)
            {
                currencyManager.playerSoftCurrency -= itemCost;  // Déduire les coins
                isItemBought = true;
                UpdateButtonText(); // Mettre à jour le texte du bouton
            }
            else
            {
                // Afficher un message si les coins sont insuffisants
                Debug.Log("Pas assez de coins pour acheter ce personnage.");
            }
        }
    }

    // Mettre à jour le texte du bouton en fonction de l'état d'achat
    private void UpdateButtonText()
    {
        if (isItemBought)
        {
            buttonText.text = "Déjà acheté";
            purchaseButton.interactable = false; // Désactiver le bouton si l'élément est déjà acheté
        }
        else
        {
            buttonText.text = "Acheter";
            purchaseButton.interactable = true; // Réactiver le bouton si l'élément n'est pas acheté
        }
    }
}
