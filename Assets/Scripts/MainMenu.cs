using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button playButton, quitButton;
    [SerializeField] private GameObject levelSelector, mainMenu;
    private void Awake()
    {
        levelSelector.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        quitButton.onClick.AddListener(Quit);
    }

    void PlayGame()
    {
        mainMenu.SetActive(false);
        levelSelector.SetActive(true);
    }

    void Quit()
    {
        Application.Quit();
    }
}
