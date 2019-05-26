using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour {

    public GameObject badShape;
    public GameObject goodShape;

    private GameObject[] shapes;

    private float t;

	// Use this for initialization
	void Start ()
    {
        shapes = new GameObject[] { badShape, goodShape };

        t = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (t >= 1.0f)
        {
            float spawnPoint = Random.Range(Camera.main.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, 0.0f)).x + 1.0f,
                Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f, 0.0f)).x - 1.0f);

            int shapeInd = Random.Range(0, 2);

            Instantiate(shapes[shapeInd], new Vector3(spawnPoint, this.transform.position.y, 0.0f), Quaternion.identity);

            t = 0.0f;
        }
        else
        {
            t += Time.deltaTime;
        }
	}
}
