using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightRandomizer : MonoBehaviour {

    public float minHeight = 1f, maxHeight = 2.5f;
    public GameObject[] Trees;

	void Start () {
        Randomize();
    }
	

    void Randomize()
    {
        for (int i = 0; i < Trees.Length; i++)
        {
            float randomSize = Random.Range(minHeight, maxHeight);
            Trees[i].transform.localScale = new Vector3(randomSize, randomSize, randomSize);
        }
    }
}
