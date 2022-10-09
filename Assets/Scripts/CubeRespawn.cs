using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRespawn : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector3 spawnPoint;

    public float respawnTreshold;
    void Start()
    {
        spawnPoint = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y <= (spawnPoint.y - respawnTreshold) || gameObject.transform.position.y >= (spawnPoint.y + respawnTreshold))
        {
            gameObject.transform.position = spawnPoint;
        }
    }
}
