using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CryingHeadController : MonoBehaviour
{

    public AudioSource globalSource;
    public AudioSource audioSource;

    public AudioSource walkingSource;

    public AudioClip crawl_sound;
    public AudioClip scream_sound;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("Crying_head_start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Audio_Crawl(){
        globalSource.clip = crawl_sound;
        globalSource.Play();
    }

    void Audio_Stop(){
        audioSource.Stop();
    }
    void Audio_StopGlobal(){
        globalSource.Stop();
    }

    void Audio_StartScream(){
        audioSource.clip = scream_sound;
        audioSource.Play();
    }

    void Audio_StartStomping(){
        walkingSource.Play();
    }
}
