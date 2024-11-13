using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] private Transform positionOne, positionTwo;

    private Transform targetPosition;

    // Start is called before the first frame update
    void Awake()
    {
        targetPosition = positionTwo;
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove();
    }

    void EnemyMove()
    {

        transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, 0.5f * Time.deltaTime);

        if (transform.position == positionOne.position)
        {
            transform.localScale = new Vector3(1, transform.localScale.y, 0);
            targetPosition = positionTwo;
        }
        else if (gameObject.transform.position == positionTwo.position)
        {
            transform.localScale = new Vector3(-1, transform.localScale.y, 0);
            targetPosition = positionOne;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<PlayerMovement>() != null)
        {
            PlayerMovement playerScript = other.gameObject.GetComponent<PlayerMovement>();
            playerScript.Death();
        }
    }
}
