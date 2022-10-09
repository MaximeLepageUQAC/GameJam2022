using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public bool isFilled;
    void Start()
    {
        isFilled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Gas")
        {
            FillGenerator();
        }
    }

    private void FillGenerator()
    {
        gameObject.GetComponent<AudioSource>().Play();
        isFilled = true;
    }
}
