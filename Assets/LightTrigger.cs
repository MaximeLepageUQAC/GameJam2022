using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    public Light light;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            light.enabled = true;
        }
    }
}
