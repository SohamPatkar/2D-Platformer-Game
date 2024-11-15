using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private Button levelOne, levelTwo, levelThree, levelFour;
    // Start is called before the first frame update
    void Start()
    {
        levelOne.onClick.AddListener(LevelOne);
        levelTwo.onClick.AddListener(LevelTwo);
        levelThree.onClick.AddListener(LevelThree);
        levelFour.onClick.AddListener(LevelFour);
    }

    void LevelOne()
    {
        LevelManager.Instance.SetLevelStatus(Levels.levelOne, LevelStatus.Unlocked);
        if (LevelManager.Instance.GetLevelStatus(Levels.levelOne) == LevelStatus.Unlocked)
        {
            SceneManager.LoadScene(Levels.levelOne);
        }
        else
        {
            Debug.Log("Not Unlocked yet");
        }
    }
    void LevelTwo()
    {
        if (LevelManager.Instance.GetLevelStatus(Levels.levelTwo) == LevelStatus.Unlocked)
        {
            SceneManager.LoadScene(Levels.levelTwo);
        }
    }
    void LevelThree()
    {
        SceneManager.LoadScene(Levels.levelThree);
    }
    void LevelFour()
    {
        SceneManager.LoadScene(Levels.levelFour);
    }
}
