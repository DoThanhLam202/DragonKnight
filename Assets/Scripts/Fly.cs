using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] float destroyBeem = 15f;
    private Animator animator;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.x - player.transform.position.x) > destroyBeem)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            animator.SetBool("Boom", true);
            Destroy(gameObject, 0.4f);
        }
        else if (collision.gameObject.CompareTag("Zombie"))
        {
            animator.SetBool("Boom", true);
            Destroy(gameObject, 0.4f);
        }
        else if (collision.gameObject.CompareTag("Boss"))
        {
            animator.SetBool("Boom", true);
            Destroy(gameObject, 0.4f);
        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("Boom", true);
            Destroy(gameObject, 0.4f);
        }
    }


}
