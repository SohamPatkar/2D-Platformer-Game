using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private Button restartLevel, quitGame, nextLevel;
    // Start is called before the first frame update

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        restartLevel.onClick.AddListener(RestartLevel);
        nextLevel.onClick.AddListener(NextLevel);
        quitGame.onClick.AddListener(QuitGame);
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void NextLevel()
    {
        LevelManager.Instance.SetLevelStatus(SceneManager.GetActiveScene().name, LevelStatus.Completed);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void QuitGame()
    {
        SceneManager.LoadScene(0);
    }
}
