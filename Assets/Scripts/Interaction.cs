using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public LayerMask mask;

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out var hit, Mathf.Infinity, mask))
        {
            var target = hit.collider.gameObject;

            Debug.Log($"looking at {target.name}", this);
            target.SendMessage("IsLookedAt", true);
        }
    }
}
