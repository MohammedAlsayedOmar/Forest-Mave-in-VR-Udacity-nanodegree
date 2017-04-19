using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked()
    // Create a boolean value called "opening" that can be checked in Update() 
    bool locked = true, opening, done;
    Animator anim;
    public AudioClip[] clip;
    AudioSource audioSource;

    void Start()
    {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clip[0];
    }

    void Update() {
        if(opening)
        {
            anim.SetTrigger("OpenDoor");
            if (!this.anim.GetCurrentAnimatorStateInfo(0).IsName("DoorOpen"))
            {
                opening = false;
                done = true;
            }
                
        }
    }

    public void OnDoorClicked() {

        if (!locked && done) //To avoid pointless clicks when door is on the floor
            return;

        if(!locked)
        {
            opening = true;
            Debug.Log("opening");
            audioSource.clip = clip[1];
            audioSource.time = 3.9f;
            audioSource.Play();

        }
        else
        {
            //play sound
            Debug.Log("clck sound");
            audioSource.Play();

        }
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        locked = false;
    }
}
