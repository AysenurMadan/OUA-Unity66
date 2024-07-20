using Unity.VisualScripting;
using UnityEngine;

public class CharacterController : Singleton<CharacterController>
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public Vector3 start;

    private Rigidbody2D r2d;
    public Animator animator;
    public bool isGrounded;
    private float horizontalInput;
    private bool isJumping;
    private bool jumpPressed;
    [SerializeField] private GameObject cameraObject;

    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        //  animator = GetComponent<Animator>();
        start = transform.position;
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        // Animasyon parametrelerini güncelle
        animator.SetFloat("speed", Mathf.Abs(horizontalInput));
        animator.SetBool("isGrounded", isGrounded);

        FlipSprite();

        // Kamera hareketi
       /* Vector3 cameraPos = new Vector3(transform.position.x, transform.position.y, cameraObject.transform.position.z);
        cameraObject.transform.position = Vector3.Lerp(cameraObject.transform.position, cameraPos, 0.1f);
       */
        // Zýplama giriþini kontrol et
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            jumpPressed = true;
        }
    }

    void FixedUpdate()
    {
        // Yerde mi kontrolü
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.22f, groundLayer);

        // Karakter hareketi
        r2d.velocity = new Vector2(horizontalInput * moveSpeed, r2d.velocity.y);

        // Zýplama
        if (jumpPressed && isGrounded)
        {
            isJumping = true;
            r2d.velocity = new Vector2(r2d.velocity.x, jumpForce);
            jumpPressed = false;
        }
    }

   /* private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            isJumping=false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }*/

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

    public void Destination()
    {
        transform.position = start;
    }
}