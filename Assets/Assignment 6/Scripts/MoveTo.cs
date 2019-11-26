using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform goal;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        goal.position = (Camera.main.GetComponent<GlobalVariables>().getClickedLocation());
        agent.destination = goal.position;
    }
}
