using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Animator animatorPlayer;

    private float speed = 1.5f;

    private void Start()
    {
        animatorPlayer = GetComponent<Animator>();
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A))
        {
            animatorPlayer.SetFloat("Speed", speed);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            animatorPlayer.SetFloat("Speed", horizontalMovement);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localScale = new Vector3(-1 * Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            animatorPlayer.SetFloat("Speed", Mathf.Abs(horizontalMovement));
        }
        else
        {
            animatorPlayer.SetFloat("Speed", horizontalMovement);
        }

    }
}
