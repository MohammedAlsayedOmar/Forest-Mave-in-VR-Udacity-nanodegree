using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpAndDown : MonoBehaviour {

    public float amplitude = 0.5f;
    public float speed = 3f;
    float oldY;

    void Start()
    {
        oldY = transform.position.y;
    }

    void Update() //animate up and down
    {
        transform.position = new Vector3(transform.position.x, oldY + amplitude * Mathf.Sin(speed * Time.time), transform.position.z);
    }
}
