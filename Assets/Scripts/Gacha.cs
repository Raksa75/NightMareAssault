using UnityEngine;
using UnityEngine.UI; // Nécessaire pour les éléments UI standards
using TMPro; // Nécessaire si tu utilises TextMeshPro

public class GachaUI : MonoBehaviour
{
    // Références aux éléments UI
    public Button gachaButton;  // Le bouton qui déclenche le tirage
    public Text resultText;     // Le texte qui affichera le résultat (si tu utilises TextMeshPro, remplace par TextMeshProUGUI)

    // Nombre de personnages possibles
    private int totalCharacters = 15;

    // Table des personnages
    private string[] characterNames = new string[] {
        "Personnage 1", "Personnage 2", "Personnage 3", "Personnage 4", "Personnage 5",
        "Personnage 6", "Personnage 7", "Personnage 8", "Personnage 9", "Personnage 10",
        "Personnage 11", "Personnage 12", "Personnage 13", "Personnage 14", "Personnage 15"
    };

    void Start()
    {
        // Vérifie que les références sont bien assignées
        if (gachaButton == null || resultText == null)
        {
            Debug.LogError("Les références UI ne sont pas assignées correctement dans l'inspecteur.");
            return; // Si les références manquent, on sort de la méthode Start pour éviter les erreurs suivantes
        }

        // Assigner la fonction de tirage à l'événement du bouton
        gachaButton.onClick.AddListener(LancerGacha);
    }

    public void LancerGacha()
    {
        // Générer un numéro aléatoire entre 0 et totalCharacters-1
        int personnageId = Random.Range(0, totalCharacters); 

        // Vérifier dans la console si le personnage est bien choisi
        Debug.Log("Personnage choisi : " + personnageId + " - " + characterNames[personnageId]);

        // Afficher le résultat dans le texte UI
        if (resultText != null)
        {
            resultText.text = "Tu as tiré : " + characterNames[personnageId];
        }
        else
        {
            Debug.LogError("Le Text (UI) n'est pas référencé dans le script.");
        }
    }
}
