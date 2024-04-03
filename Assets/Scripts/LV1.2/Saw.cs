using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
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
        if (player.transform.position.x >= 13.5f)
        {
            isFalling = true;
            targetY = -3.4f;
        }

        if (isFalling)
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