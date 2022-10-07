using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipingBehavior : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            gameObject.GetComponentInParent<BoxCollider>().enabled = false;
        }
    }
    void OnTriggerExit(Collider other) {
        if(other.tag == "Player"){
            gameObject.GetComponentInParent<BoxCollider>().enabled = true;
        }
    }
}
