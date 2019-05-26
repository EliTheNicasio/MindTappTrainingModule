using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodShape : FallingShape {

    // Use this for initialization
    void Start()
    {
        initShape();
    }

    // Update is called once per frame
    void Update()
    {
        fall();
    }
}
