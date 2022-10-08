using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRespawn : MonoBehaviour
{
    // Start is called before the first frame update

    private Transform spawnPoint;

    public float respawnTreshold;
    void Start()
    {
        spawnPoint = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y <= (spawnPoint.position.y - respawnTreshold) || gameObject.transform.position.y >= (spawnPoint.position.y + respawnTreshold))
        {
            gameObject.transform.position = spawnPoint.position;
        }
    }
}
