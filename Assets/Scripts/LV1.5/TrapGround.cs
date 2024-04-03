using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapGround : MonoBehaviour
{
    [SerializeField] float speed = 16f;
    public GameObject player;
    private bool isFalling = false;
    private float targetY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x >= 68.3f && player.transform.position.x <= 74.6f)
        {
            isFalling = true;
            targetY = -16f;
        }

        if (player.transform.position.y <= -3f&& isFalling)
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
