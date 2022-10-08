using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageDoorActivator : MonoBehaviour
{
    public GameObject garageDoor;

    private float state_closed; //the value of y axis position when the door is closed
    public float state_open; //the value of y axis position when the door is open
    private bool isOpenned;

    private bool isOpening;
    private bool isClosing;

    private float current_y; //y axis position of the door, updated every frame
    public float speed; //how fast the door moves
    private bool isLookedAt;

    // Start is called before the first frame update
    void Start()
    {
        isOpening = false;
        isClosing = false;
        state_closed = garageDoor.transform.position.y;
        state_open += state_closed;
        isOpenned = false;
    }

    //and this makes the door want to close when the player wanders away and the door stays open for too long
    private void Update()
    {
        /*
        Debug.Log("---------------------------");
        Debug.Log("IsOpening: " + isOpening);
        Debug.Log("IsClosing: " + isClosing);
        Debug.Log("IsOpenned: " + isOpenned);
        Debug.Log("State: " + garageDoor.transform.position.y);
        Debug.Log("---------------------------");
        */
        if (isOpening && garageDoor.transform.position.y < state_open) // If the door is actually moving and not yet at his fully open state, continue to open
        {
            garageDoor.transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
            isOpenned = true;
        }
        if(isClosing && garageDoor.transform.position.y > state_closed) // If the door is actually moving and not yet at his fully closed state, continue to close
        {
            garageDoor.transform.Translate(Vector3.down * Time.deltaTime * speed, Space.World);
            isOpenned = false;
        }
    }

    void OpenDoor()
    {
        current_y = garageDoor.transform.position.y;

        if (!isOpenned && garageDoor.transform.position.y <= state_closed)
        {
            Debug.Log("The door " + garageDoor.name + " is opening");
            isOpening = true;
            isClosing = false;
            garageDoor.GetComponent<AudioSource>().Play();
        }

        if (isOpenned && garageDoor.transform.position.y >= state_open)
        {
            Debug.Log("The door " + garageDoor.name + " is closing");
            isOpening = false;
            isClosing = true;
            garageDoor.GetComponent<AudioSource>().Play();
        }
    }

    void IsLookedAt(bool isLookedAt)
    {
        this.isLookedAt = isLookedAt;
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Player interacted with " + gameObject.name);
            OpenDoor();
        }
    }
}
