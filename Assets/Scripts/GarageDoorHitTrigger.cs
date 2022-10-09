using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageDoorHitTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    private bool alreadyHit;
    void Start()
    {
        alreadyHit = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && !alreadyHit)
        {
            gameObject.GetComponent<AudioSource>().Play();
            alreadyHit = true;
        }
    }
}
