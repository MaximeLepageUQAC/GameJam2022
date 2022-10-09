using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    public bool isPicked = false;

    public void PickUp (){
        gameObject.GetComponent<AudioSource>().Play();
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        gameObject.GetComponent<Light>().enabled =false;
        isPicked = true;
    } 

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            PickUp();
        }
    }
}
