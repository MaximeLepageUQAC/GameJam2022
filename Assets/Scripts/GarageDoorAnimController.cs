using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageDoorAnimController : MonoBehaviour
{
    
    private Animator anim;
    public AudioSource audioSource;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("OpenDoor");
    }
    

    void Audio_Start(){
        audioSource.Play();
    }

    void Audio_Stop(){
        audioSource.Stop();
    }

}
