using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController3 : MonoBehaviour
{
    public GameObject player;
    public GameObject trap;
    public GameObject zom;

    void Update()
    {
        if (player.transform.position.x >= 30.75f && player.transform.position.x <= 31.3f)
        {
            if (Input.GetKey(KeyCode.W))
            {
                StartCoroutine(DisableTrap());
            }
        }
        if (player.transform.position.x >= 25.5f)
        {
            zom.SetActive(true);
        }
    }

    IEnumerator DisableTrap()
    {
        yield return new WaitForSeconds(1);
        trap.SetActive(false);
    }
}
