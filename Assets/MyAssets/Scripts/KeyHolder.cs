using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHolder : MonoBehaviour {

    public GameObject keyPrefab;
    public Door[] door;
    public GameObject panelNeedKey;
    public AudioClip[] clips;

    bool haskey = false, done = false;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clips[0];
    }

    void Update()
    {
        if (!haskey && audioSource.time >= 0.57)
        {
            audioSource.Stop();
        }
    }

    public void OnHoleClicked()
    {
        if (done)
            return;
        if (haskey)
        {
            for (int i = 0; i < door.Length; i++)
            {
                door[i].Unlock();
            }
            Instantiate(keyPrefab, transform.position, transform.rotation);
            Destroy(panelNeedKey);
            //play door unlocked
            audioSource.clip = clips[1];
            audioSource.Play();
            done = true;
        }
        else
        {
            //play sound
            audioSource.Play();
        }
    }

    public void HasKey()
    {
        haskey = true;
    }
}
