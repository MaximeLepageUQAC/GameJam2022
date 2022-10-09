using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostileCamera : MonoBehaviour
{
    
    public Light light;
    public Light redLight;
    private Animator anim;

    public GameObject AlarmTrigger;

    void Start() {
        anim = transform.parent.GetComponent<Animator>();
    }


    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            light.enabled = false;
            redLight.enabled = true;
            anim.enabled = false;
            AlarmTrigger.GetComponent<AlarmLightTrigger>().enabled = true;
        }
    }

    void OnTriggerStay(Collider other) {
        if(other.gameObject.tag == "Player"){
            transform.parent.transform.LookAt(other.transform);
        }
    }

    void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "Player"){
            light.enabled = true;
            redLight.enabled = false;
            anim.enabled = true;
            AlarmTrigger.GetComponent<AlarmLightTrigger>().enabled = false;
        }
    }

}
