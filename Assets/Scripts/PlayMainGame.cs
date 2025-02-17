using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayMainGame : MonoBehaviour
{
    public Button playGame;

    private void Start()
    {
        playGame.onClick.AddListener(PlayLevel);
    }

    private void PlayLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

