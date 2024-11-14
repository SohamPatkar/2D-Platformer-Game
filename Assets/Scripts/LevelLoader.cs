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
        SceneManager.LoadScene(Levels.levelOne);
    }
    void LevelTwo()
    {
        SceneManager.LoadScene(Levels.levelTwo);
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
