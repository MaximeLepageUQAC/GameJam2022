using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverSwitchAnimController : MonoBehaviour
{
    private Animator anim;
    public AudioSource audioSource;
    public bool isOn = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("LevelOn");
    }

    public void LeverOn()
    {
        Debug.Log("Lever on");
        anim.Play("LevelOn");
        isOn = true;
    }

    public void LeverOff()
    {
        Debug.Log("Lever off");
        anim.Play("LeverOff");
        isOn = false;
    }


    void Audio_Start()
    {
        audioSource.Play();
    }

    void Audio_Stop()
    {
        audioSource.Stop();
    }
}
