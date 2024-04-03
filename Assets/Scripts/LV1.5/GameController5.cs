using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController5 : MonoBehaviour
{
    public GameObject player;
    public GameObject[] zom;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x >= 61)
        {
            for(int i = 0; i < zom.Length; i++)
            {
                zom[i].SetActive(true);
            }
        }
    }
}
