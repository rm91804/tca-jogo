// PlayerController.cs
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;   // Velocidade de movimento do jogador
    public float jumpForce = 5f;   // Força do salto do jogador

    private Rigidbody2D rb;
    private bool isJumping = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Movimento horizontal
        float moveDirection = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);

        // Pulando
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se o jogador está tocando o chão
        if (collision.contacts[0].normal.y > 0.5f) // Verifica se o ângulo da colisão é próximo de 90 graus na vertical
        {
            isJumping = false;
        }
    }
}
