using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverActivation : MonoBehaviour
{
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
        while(isLookedAt)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Interacted");
            }
        }

        isLookedAt = false;
    }
}
