using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundOut : MonoBehaviour
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
        if (player.transform.position.x >= 89.4f)
        {
            isFalling = true;
            targetY = -16f;
        }

        if (player.transform.position.y < -2f && isFalling)
        {
            StartCoroutine(moveDown());
        }
    }

    IEnumerator moveDown()
    {
        yield return new WaitForSeconds(1f);
        float newY = Mathf.MoveTowards(transform.position.y, targetY, speed * Time.deltaTime);
        transform.position = new Vector2(transform.position.x, newY);

        if (transform.position.y == targetY)
        {
            isFalling = false;
        }
    }
}
