using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject health;
    private int heartPosition;
    [SerializeField] private PlayerMovement playerStats;
    private void Awake()
    {
        playerStats.SetHealth(health.transform.childCount);
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
