using System.Collections;
using UnityEngine;


public class LevelEndScript : MonoBehaviour
{
    public GameObject gameOverUI;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<PlayerMovement>() != null)
        {
            LevelManager.Instance.GameStatusSet();
            gameOverUI.SetActive(true);
            StartCoroutine(Delay(other.gameObject));
            SoundManager.Instance.PlaySfxSound(SoundType.FinishLevel);
        }
    }

    IEnumerator Delay(GameObject playerObject)
    {
        yield return new WaitForSeconds(1f);
        Destroy(playerObject);
    }
}
