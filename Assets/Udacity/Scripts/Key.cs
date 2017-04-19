using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject keyPoofPrefab;
    public KeyHolder keyHole;

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        Instantiate(keyPoofPrefab, transform.position, Quaternion.Euler(-90f, 180f, -90f));
        keyHole.HasKey();
        Destroy(gameObject);
    }

}
