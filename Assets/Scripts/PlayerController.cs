using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject shoot;
    [SerializeField] float speed = 3f;
    [SerializeField] float force = 7.5f;
    public AudioClip jump;
    private float deadZone = -8f;
    public AudioClip beem;
    public AudioClip dead;
    private Animator animator;
    private AudioSource audio;  
    [SerializeField] float speedBeem = 900f;
    public bool isOnGround;
    public bool isOnShot;
    public bool isDead;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        isOnGround = false;
        isOnShot = false;
        audio = GetComponent<AudioSource>();
        isDead = false;
    }

    private void deadZoneY()
    {
        if(transform.position.y < deadZone)
        {
            isDead = true;
            Destroy(gameObject);
        }
    }

    public void GameNotOver()
    {
        float inputHorizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(inputHorizontal * speed, rb.velocity.y);
        if (Input.GetKey(KeyCode.W) && isOnGround)
        {
            Jump();
            audio.PlayOneShot(jump, 1f);
        }

        if (inputHorizontal > 0.01)
        {
            transform.localScale = Vector3.one;
        }
        else if (inputHorizontal < -0.01)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        Beem();
        deadZoneY();
        animator.SetBool("Walk", inputHorizontal != 0);
        animator.SetBool("Ground", !isOnGround);
        animator.SetBool("Shot", isOnShot);
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, force);
        isOnGround = false;
    }
    private void Beem()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (transform.localScale.x == 1)
            {
                Vector2 shootPosition = new Vector2(transform.position.x + 1, transform.position.y - 0.5f);
                isOnShot = true;
                var bullet = Instantiate(shoot, shootPosition, shoot.transform.rotation);
                bullet.GetComponent<Rigidbody2D>().velocity = Vector2.right * Time.deltaTime * speedBeem;
                shoot.transform.localScale = Vector3.one;
                audio.PlayOneShot(beem, 1f);
            }
            else if (transform.localScale.x == -1)
            {
                Vector2 shootPosition = new Vector2(transform.position.x + -1, transform.position.y - 0.5f);
                isOnShot = true;
                var bullet = Instantiate(shoot, shootPosition, shoot.transform.rotation);
                bullet.GetComponent<Rigidbody2D>().velocity = Vector2.left * Time.deltaTime * speedBeem;
                shoot.transform.localScale = new Vector3(-1, 1, 1);
                audio.PlayOneShot(beem, 1f);
            }

        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            isOnShot = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        if(collision.gameObject.CompareTag("Zombie"))
        {
            isDead = true;
            animator.SetTrigger("Dead");
            audio.PlayOneShot(dead, 1f);
        }
        if (collision.gameObject.CompareTag("Boss"))
        {
            isDead = true;
            animator.SetTrigger("Dead");
            audio.PlayOneShot(dead, 1f);
        }
        if (collision.gameObject.CompareTag("Trap"))
        {
            isDead = true;
            animator.SetTrigger("Dead");
            audio.PlayOneShot(dead, 1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Spike")
        {
            isDead = true;
            animator.SetTrigger("Dead");
            audio.PlayOneShot(dead, 1f);
        }
    }
}