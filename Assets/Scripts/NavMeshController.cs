using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{

    [SerializeField] private Transform movePositionTransform;
    [SerializeField] private AudioSource audioSource;

    private NavMeshAgent navMeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.destination = movePositionTransform.position;
    }

    void OnEnable(){
        audioSource.Play();
    }

    void OnDisable(){
        audioSource.Stop();
    }

}
