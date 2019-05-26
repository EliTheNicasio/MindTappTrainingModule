using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingShape : MonoBehaviour {

    protected const float speed = -5.0f;

    private float bottomBound;

	// Use this for initialization
	void Start ()
    {
	    
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    protected void initShape()
    {
        bottomBound = Camera.main.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, 0.0f)).y;
    }

    protected void fall()
    {
        float yTranslation = speed * Time.deltaTime;
        this.transform.Translate(0.0f, yTranslation, 0.0f);

        if(this.transform.position.y < bottomBound - 1.0f)
        {
            Destroy(this.gameObject);
        }
    }

}
