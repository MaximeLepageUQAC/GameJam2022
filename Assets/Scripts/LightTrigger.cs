using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    public Light light;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            light.enabled = true;
            audioSource.Play();
        }
    }
}
