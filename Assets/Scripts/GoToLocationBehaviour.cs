using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
class MyClass
{
   public int Destination { get; set; }
    [SerializeField]
    private int _destination;
   // //Field
   // public int _destination;
   //
   // //Property
   // public int Destination
   // {
   //     get { return _destination; }
   //     set { _destination = value; }
   // }


    public int GetDestination()
    {
        return _destination;
    }

    public void SetDestination(int destination)
    {
        _destination = destination;
        //RecalculatePath();
    }
}
public class GoToLocationBehaviour : MonoBehaviour {

    [SerializeField]
    private NavMeshAgent _agent;



	void Start () {
        MyClass mc = new MyClass();
        mc.Destination = 10;
        //_agent = GetComponent<NavMeshAgent>();
	}
	


	void Update () {
        if (Input.GetMouseButtonDown(0))
        {

            Vector3 mousePosition = Input.mousePosition;
            Ray worldRay = Camera.main.ScreenPointToRay(mousePosition);

            RaycastHit hitinfo;
            if(Physics.Raycast(worldRay, out hitinfo))
            {
                //Same
                //_agent.SetDestination(hitinfo.point);
                _agent.destination = hitinfo.point;

            }
        }
	}
}
