using UnityEngine;
using UnityEngine.UI;

public class Gacha : MonoBehaviour
{
    public Button gachaButton;      // Le bouton de lancement du gacha
    public Text resultText;         // Le texte qui affichera le r�sultat
    public Text gemmesText;         // Le texte qui affiche le nombre de gemmes restantes
    public HardCurrencyManager currencyManager; // R�f�rence au gestionnaire des gemmes

    private int gemmesRequired = 5; // Nombre de gemmes n�cessaires pour lancer le gacha

    void Start()
    {
        // Assigner la fonction de lancement du gacha au bouton
        gachaButton.onClick.AddListener(LancerGacha);

        // Mettre � jour l'UI initiale
        MettreAJourUI();
    }

    // Lancer le gacha
    public void LancerGacha()
    {
        // V�rifier si le joueur a assez de gemmes
        if (currencyManager.HasEnoughCurrency(gemmesRequired))
        {
            // Consommer 5 gemmes
            currencyManager.ConsumeCurrency(gemmesRequired);

            // Lancer le gacha (logique existante)
            int personnageId = Random.Range(0, 15); // Exemple : tirer un personnage au hasard
            resultText.text = "Tu as tir� : Personnage " + (personnageId + 1); // Affichage du tirage

            // Mettre � jour l'UI
            MettreAJourUI();
        }
        else
        {
            // Afficher le message d'erreur "Pas assez de gemmes"
            resultText.text = "Pas assez de gemmes";
        }
    }

    // Mettre � jour l'affichage des gemmes et du texte
    void MettreAJourUI()
    {
        // Afficher le nombre de gemmes restantes dans l'UI
        gemmesText.text = "Gems: " + currencyManager.playerHardCurrency;
    }
}
