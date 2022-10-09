using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterHeadAnimController : MonoBehaviour
{
    private Animator anim;

    public AudioClip creepy_crawl_effect;

    public AudioSource globalSource;
    // Start is called before the first frame updat
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void WalkForward()
    {
        anim.Play("CryingHead2MoveForward");
    }

    public void CreepyCrawlEffectStart()
    {
        globalSource.clip = creepy_crawl_effect;
        globalSource.Play();
    }

    public void CreepyCrawlEffectStop()
    {
        globalSource.Stop();
    }

    public void StartFinger()
    {
        anim.Play("CryingHead2MovingFinger");
    }

    public void StartTentacle()
    {
        anim.Play("CryingHead2MovingTentacle");
    }
}
