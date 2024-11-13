using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<PlayerMovement>() != null)
        {
            PlayerMovement player = other.gameObject.GetComponent<PlayerMovement>();
            player.PickUp();
            Destroy(gameObject);
        }
    }
}
