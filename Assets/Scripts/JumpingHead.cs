using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingHead : MonoBehaviour
{
    public float minRotationSpeed = 80.0f;
    //public GameObject pivot;

    bool grounded;
    void Start()
    {

    }

    void Update()
    {
        //transform.RotateAround(pivot.transform.position, Vector3.up, minRotationSpeed * Time.deltaTime);

        if (grounded)
        {
            transform.Translate(Vector3.up * 2 * Time.deltaTime, Space.World);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
    }
}
