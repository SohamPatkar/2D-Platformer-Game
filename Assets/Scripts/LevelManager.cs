using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public static LevelManager Instance { get { return instance; } }
    public Dictionary<string, int> levels = new Dictionary<string, int>();
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayerPrefs.DeleteAll();
        AddLevels();
    }

    private void AddLevels()
    {
        levels.Add(Levels.levelOne, 1);
        levels.Add(Levels.levelTwo, 2);
        levels.Add(Levels.levelThree, 3);
        levels.Add(Levels.levelFour, 4);
    }

    public void GameStatusSet()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        int nextScene = 0;

        foreach (var level in levels)
        {
            if (currentScene == level.Value)
            {
                SceneManager.LoadScene(level.Value + 1);
                nextScene = level.Value + 1;
            }
        }

        Debug.Log(nextScene);

        foreach (var keyValue in levels)
        {
            if (keyValue.Value == nextScene)
            {
                SetLevelStatus(keyValue.Key, LevelStatus.Unlocked);
            }
        }
    }

    public LevelStatus GetLevelStatus(string levelName)
    {
        LevelStatus levelStatus = (LevelStatus)PlayerPrefs.GetInt(levelName);
        return levelStatus;
    }

    public void SetLevelStatus(string levelName, LevelStatus level)
    {
        PlayerPrefs.SetInt(levelName, (int)level);
        Debug.Log(levelName + "" + level);
    }
}
