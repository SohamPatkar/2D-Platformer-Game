using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public void ShowScore(int score)
    {
        scoreText.text = "Score: " + score;
    }
}
