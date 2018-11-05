using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoToClickLocationScript : MonoBehaviour, IListener {

    private NavMeshAgent _agent;

    private void Start()
        {
        _agent = GetComponent<NavMeshAgent>();
        }

    public void ClickedAt(Vector3 pos)
        {
        _agent.destination = pos;
        }
    
}
