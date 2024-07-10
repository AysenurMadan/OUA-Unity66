using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : Singleton<CharacterController>
{

    public float speed = 1.0f;
    private Rigidbody2D r2d;
    private Animator _animator;
    private Vector3 charpos;
    private SpriteRenderer _spriteRenderer;
    [SerializeField] GameObject _camera;
    private int sayi;
    public Vector3 start;

    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    private bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();

        _spriteRenderer = GetComponent<SpriteRenderer>(); //caching sprite renderer
        r2d = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        //charpos = transform.position;
        sayi = 1;
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        UpdateAnimation();

        if (Input.GetAxis("Horizontal") == 0.0f)
        {
            _animator.SetFloat("speed", 0.0f);
        }
        else
        {
            _animator.SetFloat("speed", 1.0f);
        }

        if (Input.GetAxis("Horizontal") > 0.01f)
        {
            _spriteRenderer.flipX = false;

        }
        else if (Input.GetAxis("Horizontal") < -0.01f)

        {
            _spriteRenderer.flipX = true;
        }

        sayi = 3;
    }

    private void LateUpdate()
    {
        //  _camera.transform.position = new Vector3(charpos.x, charpos.y, charpos.z - 1.0f);

        var charpos = new Vector3(transform.position.x, transform.position.y, -10);
        _camera.transform.position = Vector3.Lerp(_camera.transform.position, charpos, 0.7f);
    }

    void Move()
    {
        float moveInput = Input.GetAxis("Horizontal");
        r2d.velocity = new Vector2(moveInput * moveSpeed, r2d.velocity.y);
    }

    void Jump()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        if (isGrounded && Input.GetKey(KeyCode.Space))
        {
            Debug.Log("mERHABA");
            r2d.velocity = new Vector2(r2d.velocity.x, jumpForce);
        }
    }

    void UpdateAnimation()
    {
        Animator animator = GetComponent<Animator>();
        if (animator != null)
        {
            if (Input.GetAxis("Horizontal") == 0.0f)
            {
                animator.SetFloat("speed", 0.0f);
            }
            else
            {
                animator.SetFloat("speed", 1.0f);
            }

            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            if (spriteRenderer != null)
            {
                if (Input.GetAxis("Horizontal") > 0.01f)
                {
                    spriteRenderer.flipX = false;
                }
                else if (Input.GetAxis("Horizontal") < -0.01f)
                {
                    spriteRenderer.flipX = true;
                }
            }
        }
    }
    public void Destination()
    {
        transform.position = start;
    }
}
