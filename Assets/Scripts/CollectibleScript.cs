using System.Collections;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    private Animator keyAnimator;
    private void Start()
    {
        keyAnimator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<PlayerMovement>() != null)
        {
            PlayerMovement player = other.gameObject.GetComponent<PlayerMovement>();
            player.PickUp();
            keyAnimator.Play("Key_Collected");
            StartCoroutine(KeyCollected());
        }
    }

    IEnumerator KeyCollected()
    {
        yield return new WaitForSeconds(0.7f);
        Destroy(gameObject);
    }
}
