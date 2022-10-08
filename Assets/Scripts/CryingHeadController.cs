using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CryingHeadController : MonoBehaviour
{

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
}
