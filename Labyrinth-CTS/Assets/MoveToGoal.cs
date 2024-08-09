using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToGoal : MonoBehaviour
{
    public Transform goal;
    private UnityEngine.AI.NavMeshAgent agent;

    // Start is called before the first frame update
    private void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = goal.position;
;   }

    // Update is called once per frame
    private void Update()
    {

    }
}
