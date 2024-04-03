using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController4 : MonoBehaviour
{
    public GameObject player;
    public GameObject zom;
    public GameObject trap;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x >= 43f)
        {
            zom.SetActive(true);
        }
    }
}
