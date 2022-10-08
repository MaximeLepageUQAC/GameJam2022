using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageDoorAnimController : MonoBehaviour
{
    
    private Animator anim;
    public AudioSource audioSource;
    public bool isOpenned = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        anim.Play("OpenDoor");
        isOpenned = true;
    }

    public void CloseDoor()
    {
        anim.Play("CloseDoor");
        isOpenned=false;
    }

    

    void Audio_Start(){
        audioSource.Play();
    }

    void Audio_Stop(){
        audioSource.Stop();
    }

}
