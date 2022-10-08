using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerSceneChanger : MonoBehaviour
{
    
    public int nextScene = 0;
    
    void OnTriggerEnter(Collider other)  
    {
        if(other.gameObject.tag == "Player"){
            SceneManager.LoadScene(nextScene);
        }
    }
}
