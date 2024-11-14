using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [Header("UI Controls")]
    public TextMeshProUGUI scoreText;
    public GameObject health, GameOver;
    [SerializeField] private PlayerMovement playerStats;
    private void Awake()
    {
        playerStats.SetHealth(health.transform.childCount);
    }

    public void GameOverScreen()
    {
        GameOver.gameObject.SetActive(true);
        Destroy(playerStats.gameObject);
    }

    public void UpdateHealth(int playerHealth)
    {
        if (playerHealth == 0)
        {
            Destroy(health);
        }
        else
        {
            Destroy(health.transform.GetChild(0).gameObject);
        }
    }

    public void ShowScore(int score)
    {
        scoreText.text = "Score: " + score;
    }
}
