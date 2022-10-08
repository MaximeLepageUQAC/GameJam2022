using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabChecker : MonoBehaviour
{
    public bool canGrab = false;
    public GameObject target = null;
    public bool grabbed = false;

    void OnTriggerEnter(Collider other)  
    {
        if(other.gameObject.tag == "HappyCube"){
            canGrab = true;
            target = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)  
    {
        if(target){
            canGrab = false;
            grabbed = false;
            target.transform.parent = null;
            target = null;
        }
    }
}
