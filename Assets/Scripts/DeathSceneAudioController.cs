using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathSceneAudioController : MonoBehaviour
{

    public AudioSource audioSource;

    public AudioClip breath_sound;
    public AudioClip scream_sound;

    void Audio_StartBreath(){
        audioSource.clip = breath_sound;
        audioSource.Play();
    }
    void Audio_StartScream(){
        audioSource.clip = scream_sound;
        audioSource.Play();
    }
    void Audio_Stop(){
        audioSource.Stop();
        SceneManager.LoadScene(0);
    }

}
