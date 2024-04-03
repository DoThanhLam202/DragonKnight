using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public GameObject player;
    public GameObject fireballPrefab;
    private Animator animator;

    public float attackCooldown = 1f;
    private float currentCooldown = 0f;
    private float count;
    public bool isDefeat;

    // Update is called once per frame

    private void Start()
    {
        isDefeat = false;
        count = 0;
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (player.transform.position.x >= 114f && player.transform.position.x <= 125f)
        {
            currentCooldown -= Time.deltaTime;
            if (currentCooldown <= 0f)
            {
                Vector2 spawnPotision = new Vector2(125.4f, Random.Range(-3.7f, 3.7f));
                Instantiate(fireballPrefab, spawnPotision, Quaternion.identity);
                currentCooldown = attackCooldown;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Shoot")
        {
            count++;
            if (count == 1000000)
            {
                animator.SetTrigger("Dead");
                StartCoroutine(die());
                isDefeat = true;
            }
        }
    }

    IEnumerator die()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}