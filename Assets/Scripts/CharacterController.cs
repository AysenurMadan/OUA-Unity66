using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private Rigidbody2D r2d;
    private Animator animator;
    private bool isGrounded;
    private float horizontalInput;
    private bool isJumping;
    [SerializeField] private GameObject cameraObject;

    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        // Animasyon parametrelerini güncelle
        animator.SetFloat("speed", Mathf.Abs(horizontalInput));
        animator.SetBool("isGrounded", isGrounded);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isJumping = true;
            animator.SetTrigger("jump");
        }

        FlipSprite();

        // Kamera hareketi
        Vector3 cameraPos = new Vector3(transform.position.x, transform.position.y, cameraObject.transform.position.z);
        cameraObject.transform.position = Vector3.Lerp(cameraObject.transform.position, cameraPos, 0.1f);
    }

    void FixedUpdate()
    {
        // Yerde mi kontrolü
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        // Karakter hareketi
        r2d.velocity = new Vector2(horizontalInput * moveSpeed, r2d.velocity.y);

        // Zýplama
        if (isJumping)
        {
            r2d.velocity = new Vector2(r2d.velocity.x, jumpForce);
            isJumping = false;
        }
    }

    void FlipSprite()
    {
        if (horizontalInput > 0.01f)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
