using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private Button restartLevel, quitGame;
    // Start is called before the first frame update

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        restartLevel.onClick.AddListener(RestartLevel);
        quitGame.onClick.AddListener(QuitGame);
    }

    void RestartLevel()
    {
        SceneManager.LoadScene("Level1");
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
