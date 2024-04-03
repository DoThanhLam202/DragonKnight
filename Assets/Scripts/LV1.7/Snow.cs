using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] float speed = 150;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.left * speed * Time.deltaTime;
        if(transform.position.y <= -10f)
        {
            Destroy(gameObject);
        }
    }
}
