using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour {

    public Direction direction;
    public int count;
    public float distanceBetween;
    public GameObject[] objects;
    public float rot = 0;

	void Start()
    {
        int index = 0;
		switch(direction)
        {
            case Direction.posZ:
                float instaZ = transform.position.z;
                for (int i = 0; i < count; i++)
                {
                    index = Random.Range(0, objects.Length);
                    Instantiate(objects[index], new Vector3(transform.position.x, transform.position.y, instaZ), Quaternion.Euler(0, rot, 0));
                    instaZ += distanceBetween;
                }
                break;
            case Direction.negZ:
                float instaZ2 = transform.position.z;
                for (int i = 0; i < count; i++)
                {
                    index = Random.Range(0, objects.Length);
                    Instantiate(objects[index], new Vector3(transform.position.x, transform.position.y, instaZ2), Quaternion.Euler(0, rot, 0));
                    instaZ2 -= distanceBetween;
                }
                break;
            case Direction.posX:
                float instaX = transform.position.x;
                for (int i = 0; i < count; i++)
                {
                    index = Random.Range(0, objects.Length);
                    Instantiate(objects[index], new Vector3(instaX, transform.position.y, transform.position.z), Quaternion.Euler(0, rot, 0));
                    instaX += distanceBetween;
                }
                break;
            case Direction.negX:
                float instaX2 = transform.position.x;
                for (int i = 0; i < count; i++)
                {
                    index = Random.Range(0, objects.Length);
                    Instantiate(objects[index], new Vector3(instaX2, transform.position.y, transform.position.z), Quaternion.Euler(0, rot, 0));
                    instaX2 -= distanceBetween;
                }
                break;
        }

	}
	
	void Update () {
		
	}

    public enum Direction
    {
        posX,
        negX,
        posZ,
        negZ
    };
}
