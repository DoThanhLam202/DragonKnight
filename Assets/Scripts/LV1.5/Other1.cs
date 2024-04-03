using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Other1 : MonoBehaviour
{
    [SerializeField] float speed = 16f;
    public GameObject player;
    private bool isFalling = false;
    private float targetX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x >= 68.0f)
        {
            if(player.transform.position.y >= -0.6192051f)
            {
                isFalling = true;
                targetX = -66f;
                if(isFalling)
                {
                    StartCoroutine(shiuuuu());
                }
            }
        }
    }

    IEnumerator shiuuuu()
    {
        yield return new WaitForSeconds(1f);
        float newY = Mathf.MoveTowards(transform.position.x, targetX, speed * Time.deltaTime);
        transform.position = new Vector2(newY, transform.position.y);

        if (transform.position.y == targetX)
        {
            isFalling = false;
        }
    }
}
