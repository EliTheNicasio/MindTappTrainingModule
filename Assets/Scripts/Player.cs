using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    const float speed = 6.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float translation = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        this.transform.Translate(translation, 0f, 0f);
    }
}
