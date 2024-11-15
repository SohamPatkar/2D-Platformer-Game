using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public static LevelManager Instance { get { return instance; } }

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

    public void GameStatusSet()
    {

    }

    public LevelStatus GetLevelStatus(string levelName)
    {
        LevelStatus levelStatus = (LevelStatus)PlayerPrefs.GetInt(levelName);
        return levelStatus;
    }

    public void SetLevelStatus(string levelName, LevelStatus level)
    {
        PlayerPrefs.SetInt(levelName, (int)level);
    }


}
