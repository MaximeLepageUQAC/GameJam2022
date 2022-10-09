using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip engineClip;
    [SerializeField] private AudioClip startedClip;


    private int attemps = 0;
    private bool isLookedAt;

    void StartCar(){
        if(attemps == 3){
            audioSource.Stop();
            audioSource.clip = startedClip;
            audioSource.Play();
        }
        else if(attemps >= 3){
            SceneManager.LoadScene(5);
        }
        else{
            audioSource.Stop();
            audioSource.clip = engineClip;
            audioSource.Play();
            attemps++;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            StartCar();
        }
    }

}
