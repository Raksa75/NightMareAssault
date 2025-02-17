using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button playButton;
    public Button shopButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        shopButton.onClick.AddListener(OpenShop);
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("DeckBuilding");
    }

    private void OpenShop()
    {
        SceneManager.LoadScene("Shop");
        Debug.Log("Shop button clicked");
    }
}

