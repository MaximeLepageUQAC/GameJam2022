using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioController : MonoBehaviour
{

    [SerializeField] private AudioSource carSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Audio_CarKeys(){
        carSource.Play();
    }

    void EndScene(){
        SceneManager.LoadScene(7);
    }
}
