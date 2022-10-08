using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public int nextScene = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void changeScene(int sceneNbr)
    {
        SceneManager.LoadScene(sceneNbr);
    }
    public void changeScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}
