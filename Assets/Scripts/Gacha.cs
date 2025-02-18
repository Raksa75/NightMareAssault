using UnityEngine;
using UnityEngine.UI; // N�cessaire pour les �l�ments UI standards
using TMPro; // N�cessaire si tu utilises TextMeshPro

public class GachaUI : MonoBehaviour
{
    // R�f�rences aux �l�ments UI
    public Button gachaButton;  // Le bouton qui d�clenche le tirage
    public Text resultText;     // Le texte qui affichera le r�sultat (si tu utilises TextMeshPro, remplace par TextMeshProUGUI)

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
        // V�rifie que les r�f�rences sont bien assign�es
        if (gachaButton == null || resultText == null)
        {
            Debug.LogError("Les r�f�rences UI ne sont pas assign�es correctement dans l'inspecteur.");
            return; // Si les r�f�rences manquent, on sort de la m�thode Start pour �viter les erreurs suivantes
        }

        // Assigner la fonction de tirage � l'�v�nement du bouton
        gachaButton.onClick.AddListener(LancerGacha);
    }

    public void LancerGacha()
    {
        // G�n�rer un num�ro al�atoire entre 0 et totalCharacters-1
        int personnageId = Random.Range(0, totalCharacters); 

        // V�rifier dans la console si le personnage est bien choisi
        Debug.Log("Personnage choisi : " + personnageId + " - " + characterNames[personnageId]);

        // Afficher le r�sultat dans le texte UI
        if (resultText != null)
        {
            resultText.text = "Tu as tir� : " + characterNames[personnageId];
        }
        else
        {
            Debug.LogError("Le Text (UI) n'est pas r�f�renc� dans le script.");
        }
    }
}
