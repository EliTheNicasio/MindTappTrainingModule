using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrapper : MonoBehaviour {

    public float leftBound;
    public float rightBound;
    const float buffer = 1.0f;

    private GameObject player;

	// Use this for initialization
	void Start ()
    {
        leftBound = Camera.main.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, 0.0f)).x;
        rightBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f, 0.0f)).x;

        player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(player.GetComponent<Transform>().position.x < leftBound - buffer)
        {
            player.GetComponent<Transform>().position = new Vector3(rightBound + buffer, player.GetComponent<Transform>().position.y, player.GetComponent<Transform>().position.z);
        }

        if (player.GetComponent<Transform>().position.x > rightBound + buffer)
        {
            player.GetComponent<Transform>().position = new Vector3(leftBound - buffer, player.GetComponent<Transform>().position.y, player.GetComponent<Transform>().position.z);
        }
    }
}
