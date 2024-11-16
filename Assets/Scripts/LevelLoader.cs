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
            SoundManager.Instance.PlaySfxSound(SoundType.ButtonClick);
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
            SoundManager.Instance.PlaySfxSound(SoundType.ButtonClick);
            SceneManager.LoadScene(Levels.levelTwo);
        }
    }
    void LevelThree()
    {
        if (LevelManager.Instance.GetLevelStatus(Levels.levelThree) == LevelStatus.Unlocked)
        {
            SceneManager.LoadScene(Levels.levelThree);
        }
        else
        {
            Debug.Log("Not Unlocked yet");
        }
    }
    void LevelFour()
    {
        if (LevelManager.Instance.GetLevelStatus(Levels.levelFour) == LevelStatus.Unlocked)
        {
            SceneManager.LoadScene(Levels.levelFour);
        }
        else
        {
            Debug.Log("Not Unlocked yet");
        }
    }
}
