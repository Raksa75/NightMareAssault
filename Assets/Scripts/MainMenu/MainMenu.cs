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
        SceneManager.LoadScene("SampleScene");
    }

    private void OpenShop()
    {
        // You can add functionality to open the shop scene or UI here.
        Debug.Log("Shop button clicked");
    }
}

