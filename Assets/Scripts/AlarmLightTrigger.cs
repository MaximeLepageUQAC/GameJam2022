using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AlarmLightTrigger : MonoBehaviour
{

    [SerializeField] public List<Light> lights;
    [SerializeField] public AudioSource audioSource;
    [SerializeField] public GameObject agent;
    
    void OnEnable() {
        foreach(Light l in lights){
            l.enabled = false;
        }
        
        audioSource.Play();
        agent.GetComponent<NavMeshController>().enabled = true;
    }

    void OnDisable() {
        foreach(Light l in lights){
            l.enabled = true;
        }
        
        audioSource.Stop();
        agent.GetComponent<NavMeshController>().enabled = false;
    }
    
}
