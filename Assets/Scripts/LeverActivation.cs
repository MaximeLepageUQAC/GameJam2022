using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverActivation : MonoBehaviour
{
    public GameObject garageDoor;

    private float state_closed; //the value of y axis position when the door is closed
    private float state_open; //the value of y axis position when the door is open
    private bool isOpenned;
    private bool opening;
    private float current_y; //y axis position of the door, updated every frame
    public float speed; //how fast the door moves

    // Start is called before the first frame update
    void Start()
    {
        state_closed = garageDoor.transform.position.y;
        state_open = state_closed + 3f;
        isOpenned = false;
    }

    //and this makes the door want to close when the player wanders away and the door stays open for too long
    private void Update()
    {
        if(opening && garageDoor.transform.position.y == state_open)
        {
            garageDoor.transform.Translate(Vector3.up * Time.deltaTime * speed);
            isOpenned = true;
        }
        else if(!opening && garageDoor.transform.position.y == state_closed)
        {
            garageDoor.transform.Translate(Vector3.down * Time.deltaTime * speed);
            isOpenned = false;
        }
    }

    void OpenDoor()
    {
        current_y = garageDoor.transform.position.y;


        if (!isOpenned)
        {
            Debug.Log("The door " + garageDoor.name + " is opening");
            opening = true;
        }

        if (isOpenned)
        {
            Debug.Log("The door " + garageDoor.name + " is closing");
            opening = false;
        }
    }

    void IsLookedAt(bool isLookedAt)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Player interacted with " + gameObject.name);
            OpenDoor();
        }
    }
}
