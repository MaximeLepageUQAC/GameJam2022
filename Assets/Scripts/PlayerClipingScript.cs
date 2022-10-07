using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClipingScript : MonoBehaviour
{
    public bool IsCollidingCube = false;

    void OnCollisionEnter(Collision other) {
        Debug.Log(other.gameObject.tag);

        if(other.gameObject.tag == "HappyCube"){
            IsCollidingCube = true;
        }
    }

    void OnCollisionExit(Collision other) {
        if(other.gameObject.tag == "HappyCube"){
            IsCollidingCube = false;
        }
    }
}
