using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitSceneChanger : MonoBehaviour
{
    // Start is called before the first frame update

    public float delayBeforeChanging;

    private float timeElapsed;

    public int sceneToLoad;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeChanging)
        {
            changeScene(sceneToLoad);
        }
    }

    public void changeScene(int sceneNbr)
    {
        SceneManager.LoadScene(sceneNbr);
    }
}
