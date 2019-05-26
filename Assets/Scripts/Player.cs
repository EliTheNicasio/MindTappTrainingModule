using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int lives;
    public int score;

    const float speed = 6.0f;

	// Use this for initialization
	void Start ()
    {
        lives = 3;
        score = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float translation = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        this.transform.Translate(translation, 0f, 0f);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.name.Contains("Good"))
        {
            score += 10;
        }
        if(collider.gameObject.name.Contains("Bad"))
        {
            if (lives > 0)
                lives--;
        }

        Destroy(collider.gameObject);
    }
}
