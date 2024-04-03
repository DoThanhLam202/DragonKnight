using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Other : MonoBehaviour
{
    [SerializeField] float speed = 16f;
    public GameObject player;
    private bool isFalling = false;
    private float targetY;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x >= 50f)
        {
            isFalling = true;
            targetY = 6f;
        }

        if (Input.GetKey(KeyCode.W) && isFalling)
        {
            float newY = Mathf.MoveTowards(transform.position.y, targetY, speed * Time.deltaTime);
            transform.position = new Vector2(transform.position.x, newY);

            if (transform.position.y == targetY)
            {
                isFalling = false;
            }
        }
    }
}
