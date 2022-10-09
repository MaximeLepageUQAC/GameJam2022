using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseDoor : MonoBehaviour
{
    private bool isLookedAt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IsLookedAt(bool isLookedAt)
    {
        Debug.Log("The door is looked at");
        this.isLookedAt = isLookedAt;
        if (Input.GetKeyDown(KeyCode.E))
        {
            gameObject.GetComponent<SceneChanger>().changeScene();
        }
    }
}
