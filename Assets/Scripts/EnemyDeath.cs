using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<PlayerMovement>() != null)
        {
            Destroy(gameObject.transform.parent.gameObject);
        }
    }
}
