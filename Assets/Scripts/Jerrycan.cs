using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jerrycan : MonoBehaviour
{
    public bool isFilled;

    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isFilled)
        {
            rb.mass += 1;
        }
    }
}
