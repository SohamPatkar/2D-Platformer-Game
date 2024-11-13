using TMPro;

public class ScoreController
{
    public TextMeshProUGUI scoreText;

    public void ShowScore(int score)
    {
        scoreText.text = "Score: " + score;
    }
}
