using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAuto : MonoBehaviour
{
    [SerializeField] float speed = 80f;
    private float temp;
    public bool isMovingRight;
    private Rigidbody2D rbEnemy;
    private Animator anim;
    private int count;

    private void Start()
    {
        isMovingRight = false;
        rbEnemy = GetComponent<Rigidbody2D>();
        temp = transform.localScale.x;
        anim = GetComponent<Animator>();
        count = 0;
    }

    private void Update()
    {
        if (isMovingRight == false)
        {
            rbEnemy.velocity = new Vector2(-1f * speed * Time.deltaTime, rbEnemy.velocity.y);
            transform.localScale = new Vector3(temp, transform.localScale.y, transform.localScale.z);
            anim.SetBool("Walk",true);
        }
        else
        {
            rbEnemy.velocity = new Vector2(1f * speed * Time.deltaTime, rbEnemy.velocity.y);
            transform.localScale = new Vector3(-temp, transform.localScale.y, transform.localScale.z);
            anim.SetBool("Walk", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            isMovingRight = !isMovingRight;
        }
        else if (collision.gameObject.tag == "Zombie")
        {
            isMovingRight = !isMovingRight;
        }
        if (collision.gameObject.tag == "Player")
        {
            anim.SetBool("Walk", false);
            anim.SetBool("Attack", true);
            Destroy(collision.gameObject, 0.5f);
        }
        if(collision.gameObject.tag == "Shoot")
        {
            count++;
            if(count == 3)
            {
                Destroy(gameObject);
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetBool("Walk", true);
            anim.SetBool("Attack", false);
        }
    }

}
