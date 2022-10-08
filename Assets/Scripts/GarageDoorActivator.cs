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

    void IsLookedAt(bool isLookedAt)
    {
        this.isLookedAt = isLookedAt;
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Player interacted with " + gameObject.name);
            if (garageDoor.GetComponent<GarageDoorAnimController>().isOpenned)
            {
                garageDoor.GetComponent<GarageDoorAnimController>().CloseDoor();

                if (gameObject.GetComponent<LeverSwitchAnimController>().isOn)
                {
                    gameObject.GetComponent<LeverSwitchAnimController>().LeverOff();
                }
            }
            else
            {
                garageDoor.GetComponent<GarageDoorAnimController>().OpenDoor();

                if (!gameObject.GetComponent<LeverSwitchAnimController>().isOn)
                {
                    gameObject.GetComponent<LeverSwitchAnimController>().LeverOn();
                }
            }
        }
    }
}
