using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMenu : MonoBehaviour
{
    public Button ToMainMenu;

    private void Start()
    {
        ToMainMenu.onClick.AddListener(Menu);
    }

    private void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

