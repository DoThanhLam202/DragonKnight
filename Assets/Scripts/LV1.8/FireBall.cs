using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    private Rigidbody2D tr;
    [SerializeField] float sap = 300f;
    void Start()
    {
        tr = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        tr.velocity = Vector2.left * Time.deltaTime * sap;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        if(collision.transform.position.x <= -30f)
        {
            Destroy(gameObject);
        }
    }
}
