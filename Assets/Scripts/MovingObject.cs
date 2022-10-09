using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;

    public Rigidbody rb;

    public float necessaryVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if(necessaryVelocity == 0f)
        {
            necessaryVelocity = 0.5f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude > necessaryVelocity)
        {
            Debug.Log(gameObject.name + " is moving");
            audioSource.Play();
        }
    }
}
