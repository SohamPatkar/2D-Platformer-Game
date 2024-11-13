using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEndScript : MonoBehaviour
{
    [SerializeField] private string nextScene;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<PlayerMovement>() != null)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
