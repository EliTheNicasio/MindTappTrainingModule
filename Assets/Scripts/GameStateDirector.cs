using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateDirector : MonoBehaviour
{
    public GameObject player;
    public GameObject gameOverScreen;
    public GameObject shapeSpawner;

    bool isGameOver;

	// Use this for initialization
	void Start ()
    {
        isGameOver = false;
        gameOverScreen.SetActive(false);
        shapeSpawner.SetActive(true);
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if(player.GetComponent<Player>().lives <= 0)
        {
            isGameOver = true;
        }
        else
        {
            isGameOver = false;
        }

        if(isGameOver)
        {
            Time.timeScale = 0.0f;
            gameOverScreen.SetActive(true);
            shapeSpawner.SetActive(false);
        }
	}

    public void restart()
    {
        gameOverScreen.SetActive(false);
        Time.timeScale = 1.0f;

        shapeSpawner.SetActive(true);
        foreach(Transform child in GameObject.Find("shapeRoot").GetComponent<Transform>())
        {
            Destroy(child.gameObject);
        }

        player.GetComponent<Player>().reset();
    }
}
