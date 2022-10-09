using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkGeneratorDoor : MonoBehaviour
{
    [SerializeField] private GameObject generator;
    [SerializeField] private GameObject door;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(generator.GetComponent<Generator>().isFilled)
        {
            door.GetComponent<GarageDoorAnimController>().OpenDoor();
        }
    }
}
