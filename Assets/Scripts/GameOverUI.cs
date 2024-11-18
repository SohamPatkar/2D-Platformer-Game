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
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            nextLevel.enabled = false;
        }
        nextLevel.onClick.AddListener(NextLevel);
        quitGame.onClick.AddListener(QuitGame);
    }

    void RestartLevel()
    {
        SoundManager.Instance.PlaySfxSound(SoundType.ButtonClick);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void NextLevel()
    {
        SoundManager.Instance.PlaySfxSound(SoundType.ButtonClick);
        LevelManager.Instance.SetLevelStatus(SceneManager.GetActiveScene().name, LevelStatus.Completed);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void QuitGame()
    {
        SoundManager.Instance.PlaySfxSound(SoundType.ButtonClick);
        SceneManager.LoadScene(0);
    }
}
