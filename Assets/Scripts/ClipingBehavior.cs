using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipingBehavior : MonoBehaviour
{
    void OnTriggerEnter(Collider other)  
    {
        if(other.gameObject.tag == "Player" && other.gameObject.GetComponent<PlayerClipingScript>().IsCollidingCube){
            gameObject.transform.parent.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    void OnTriggerExit(Collider other)  
    {
        if(other.gameObject.tag == "Player"){
            gameObject.transform.parent.gameObject.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
