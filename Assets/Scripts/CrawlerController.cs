using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrawlerController : MonoBehaviour
{
    [SerializeField] public List<Light> lights;
    [SerializeField] public AudioSource audioSource;
    [SerializeField] public GameObject crawlers;
    
    void OnEnable() {
        foreach(Light l in lights){
            l.enabled = false;
        }
        StartCrawlers();
        audioSource.Play();
    }

    void OnDisable() {
        foreach(Light l in lights){
            l.enabled = true;
        }
        
        audioSource.Stop();
    }

    private void StartCrawlers(){
        crawlers.gameObject.SetActive(true);
    }
    
}
