using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class GoToLocationScript : MonoBehaviour {
    

    private NavMeshAgent _agent;

	// Use this for initialization
	void Start () {
        _agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
            {
            //get mouse position
            Vector3 mousePos = Input.mousePosition;
            Ray mouseRay = Camera.main.ScreenPointToRay(mousePos);

            //do raycast
            RaycastHit hit;
            if (Physics.Raycast(mouseRay, out hit, 99, ~LayerMask.GetMask("Player")))
                {
                //set agent destination
                _agent.destination = hit.point;
                }
            }
	}
}
