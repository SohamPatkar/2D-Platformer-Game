using UnityEngine.SceneManagement;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            SoundManager.Instance.PlayBackGroundMusic(SoundType.BackgroundMusic);
        }
    }
}
