using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool isGameOver;
    public bool isGameWinner;
    private PlayerController player;
    private Wizard wizard;
    public GameObject titleOver;
    public GameObject titleWinner;
    public GameObject playerCheck;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        isGameWinner = false;
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        wizard = GameObject.Find("Boss").GetComponent<Wizard>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver == false)
        {
            player.GameNotOver();
        }

        if(player.isDead == true)
        {
            isGameOver = true;
        }
        if(playerCheck.transform.position.y < -8f)
        {
            isGameOver = true;
        }
        if(isGameOver)
        {
            titleOver.SetActive(true);
        }
        if (wizard.isDefeat == true)
        {
            isGameWinner = true;
        }
        if(isGameWinner)
        {
           titleWinner.SetActive(true);
        }
    }

    public void loadScene()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
