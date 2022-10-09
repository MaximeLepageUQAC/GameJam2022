using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip engineClip;
    [SerializeField] private AudioClip startedClip;
    [SerializeField] private GameObject keys;


    private bool canLeave = false;
    private bool isLookedAt;

    void StartCar(){

        if(canLeave){
            SceneManager.LoadScene(5);
        }
        else if(keys.GetComponent<KeyController>().isPicked){
            audioSource.Stop();
            audioSource.clip = startedClip;
            audioSource.Play();
            canLeave = true;
        }
        else{
            audioSource.Stop();
            audioSource.clip = engineClip;
            audioSource.Play();
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            StartCar();
        }
    }

}
