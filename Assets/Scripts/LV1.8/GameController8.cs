using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController8 : MonoBehaviour
{
    public GameObject player;
    public GameObject wizard;
    public GameObject sand;
    private float time_spawn = 2f;
    private float count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x >= 112.5f)
        {
            wizard.SetActive(true);
        }

        count -= Time.deltaTime;
        if(count < 0)
        {
            spawnSand();
            count = time_spawn;
        }
    }

    void spawnSand()
    {
        Vector2 spawn = new Vector2(Random.Range(114f, 125f), 6);
        Instantiate(sand, spawn, Quaternion.identity);
    }
}
