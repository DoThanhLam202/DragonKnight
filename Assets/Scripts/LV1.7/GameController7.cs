using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController7 : MonoBehaviour
{
    public GameObject snow;
    public GameObject player;
    private bool spawningSnow = false;

    void Update()
    {
        if (player.transform.position.x >= 95f && !spawningSnow)
        {
            StartCoroutine(SpawnSnowCoroutine());
        }
    }

    IEnumerator SpawnSnowCoroutine()
    {
        spawningSnow = true;

        while (player.transform.position.x >= 95f && player.transform.position.x <= 112.5f)
        {
            SpawnSnow();
            SpawnSnow2();
            SpawnSnow4();
            yield return new WaitForSeconds(2f);
            SpawnSnow1();
            SpawnSnow3();
            SpawnSnow5();
            yield return new WaitForSeconds(1f);
        }

        spawningSnow = false;
    }

    void SpawnSnow()
    {
        Vector2 spawnPosition = new Vector2(113f, 3.3f);
        Instantiate(snow, spawnPosition, Quaternion.identity);
    }
    void SpawnSnow1()
    {
        Vector2 spawnPosition = new Vector2(113f, 1.7f);
        Instantiate(snow, spawnPosition, Quaternion.identity);
    }
    void SpawnSnow2()
    {
        Vector2 spawnPosition = new Vector2(113f, 0.24f);
        Instantiate(snow, spawnPosition, Quaternion.identity);
    }
    void SpawnSnow3()
    {
        Vector2 spawnPosition = new Vector2(113f, -1.09f);
        Instantiate(snow, spawnPosition, Quaternion.identity);
    }
    void SpawnSnow4()
    {
        Vector2 spawnPosition = new Vector2(113f, -2.34f);
        Instantiate(snow, spawnPosition, Quaternion.identity);
    }
    void SpawnSnow5()
    {
        Vector2 spawnPosition = new Vector2(113f, -3.8f);
        Instantiate(snow, spawnPosition, Quaternion.identity);
    }
}