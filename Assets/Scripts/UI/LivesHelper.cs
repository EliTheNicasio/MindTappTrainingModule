using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesHelper : MonoBehaviour {

    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

    GameObject[] lifeObjects;

    public GameObject player;

	// Use this for initialization
	void Start ()
    {
        lifeObjects = new GameObject[] { life1, life2, life3 };
	}
	
	// Update is called once per frame
	void Update ()
    {
        int lives = player.GetComponent<Player>().lives;

        if(lives == 3)
        {
            foreach(GameObject obj in lifeObjects)
            {
                obj.GetComponent<SpriteRenderer>().enabled = true;
            }
        }
        else if (lives == 2)
        {
            for(int i = 0; i < 3; i++)
            {
                if(i == 2)
                {
                    lifeObjects[i].GetComponent<SpriteRenderer>().enabled = false;
                }
                else
                {
                    lifeObjects[i].GetComponent<SpriteRenderer>().enabled = true;
                }
            }
        }
        else if (lives == 1)
        {
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    lifeObjects[i].GetComponent<SpriteRenderer>().enabled = true;
                }
                else
                {
                    lifeObjects[i].GetComponent<SpriteRenderer>().enabled = false;
                }
            }
        }
        else if(lives <=0)
        {
            foreach (GameObject obj in lifeObjects)
            {
                obj.GetComponent<SpriteRenderer>().enabled = false;
            }
        }
	}
}
