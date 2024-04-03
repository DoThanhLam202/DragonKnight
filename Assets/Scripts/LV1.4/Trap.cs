using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] float speed = 16f;
    public GameObject player;
    private bool isFalling = false;
    private float targetY;

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x >= 48f)
        {
            isFalling = true;
            targetY = -4.5f;
        }

        if (player.transform.position.y < -2f &&  isFalling)
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
