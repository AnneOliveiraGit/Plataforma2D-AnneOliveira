using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 8f;
    public AudioClip jumpSound;

    private Rigidbody2D rb;
    private Animator animator;
    private bool isGrounded;
    private AudioSource audioSource;

    public static AudioSource audioSourcePlayer; // Referência global para som de coletável
    public AudioClip damageSound; // novo som de dano

    public void TocarSomDano()
    {
        if (audioSource != null && damageSound != null)
        {
            audioSource.PlayOneShot(damageSound);
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

        audioSourcePlayer = audioSource; // Define referência estática
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");

        // Movimento horizontal
        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);

        // Animação de corrida
        animator.SetBool("isRunning", Mathf.Abs(move) > 0.1f);

        // Animação de pulo
        animator.SetBool("isJumping", !isGrounded);

        // Pulo
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            audioSource.PlayOneShot(jumpSound);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
            isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
            isGrounded = false;
    }
}
