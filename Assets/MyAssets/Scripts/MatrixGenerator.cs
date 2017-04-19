using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixGenerator : MonoBehaviour {

    public Vector2 size;
    float distance = 4f;
    public GameObject[] objects;

    void Start () {
        Generate();
	}

    void Generate()
    {
        int index = 0, indexRot = 0;
        Vector3 pos = transform.position;
        float[] rotRand = { 0, 90, 180, 270 };
        for (int i = 0; i < size.x; i++)
        {
            pos = new Vector3(i * distance + transform.position.x, 0f, pos.z);
            for (int j = 0; j < size.y; j++)
            {
                index = Random.Range(0, objects.Length);
                indexRot = Random.Range(0, rotRand.Length);
                Quaternion rot = Quaternion.Euler(new Vector3(-90f,0f,rotRand[indexRot]));
                pos = new Vector3(pos.x, 0f, j * distance + transform.position.z);
                Instantiate(objects[index], pos, rot);                
            }

        }
    }
}
