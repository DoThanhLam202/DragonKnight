using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject Tutorial;
    public GameObject trap;
    public GameObject[] ground;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        turnOffTutorial();
        turnOn();
        turnOffGround();
    }

    void turnOffTutorial()
    {
        if(player.transform.position.x >= 0)
        {
            Tutorial.SetActive(false);
        }
    }

    void turnOn()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            if(player.transform.position.x < 0)
            {
                StartCoroutine(onTrap());
            }
        }
    }

    IEnumerator onTrap()
    {
        yield return new WaitForSeconds(0.5f);
        trap.SetActive(true);
    }

    void turnOffGround()
    {
        if(player.transform.position.x >= 3.3f)
        {
            for(int i=0;i<ground.Length; i++)
            {
                ground[i].SetActive(false);
            }
        }
    }
}
