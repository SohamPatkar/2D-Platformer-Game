using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator animatorPlayer;
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    private Rigidbody2D rb2D;
    private bool IsCrouching = false;
    private bool IsGrounded = true;

    private void Awake()
    {
        animatorPlayer = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");

        if (horizontalMovement < 0)
        {
            transform.localScale = new Vector3(-1, 1, 0);
        }
        else if (horizontalMovement > 0)
        {
            transform.localScale = new Vector3(1, 1, 0);
        }

        animatorPlayer.SetFloat("Speed", Mathf.Abs(horizontalMovement));
        DirectionalMovement(horizontalMovement);

        Sprint();
        Crouch();
        Jump();
    }

    void DirectionalMovement(float speedX)
    {
        if (speedX > 0.25 || speedX < 0.25)
        {
            transform.Translate(new Vector3(speedX * Time.deltaTime, 0, 0));
        }
    }

    void Sprint()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animatorPlayer.SetFloat("Speed", Mathf.Abs(speed));
            if (transform.localScale.x < 0)
            {
                transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            }
            else
            {
                transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            }
        }
    }

    void Crouch()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            animatorPlayer.SetTrigger("IsCrouched");
        }
        else if (IsCrouching == true)
        {
            animatorPlayer.SetBool("IsCrouching", false);
        }
    }

    void Jump()
    {
        Debug.Log(IsGrounded);
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
        {
            rb2D.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            animatorPlayer.SetBool("IsJumping", true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            IsGrounded = true;
            animatorPlayer.SetBool("IsJumping", false);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            IsGrounded = false;
        }
    }
}
