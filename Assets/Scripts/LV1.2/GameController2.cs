using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController2 : MonoBehaviour
{
    public GameObject player;
    public GameObject block;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x > 12f && player.transform.position.x < 13f)
        {
            if(Input.GetKey(KeyCode.W))
            {
                block.SetActive(true);
            }
            
        }
    }
}
