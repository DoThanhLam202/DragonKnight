using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class GameController6 : MonoBehaviour
{
    public GameObject player;
    public GameObject trap;
    public GameObject block;
    public GameObject block1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x >= 85.3f)
        {
            if (player.transform.position.y <= -2.9f)
            {
                trap.SetActive(true);
            }
        }
        if (player.transform.position.x > 84.5f && player.transform.position.x < 85f)
        {
            if (Input.GetKey(KeyCode.W))
            {
                block.SetActive(true);
            }

        }

        if (player.transform.position.x > 85f && player.transform.position.x < 85.5f)
        {
            if (Input.GetKey(KeyCode.W))
            {
                block1.SetActive(true);
            }

        }
    }
}
