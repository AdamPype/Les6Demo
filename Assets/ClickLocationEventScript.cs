using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public interface IListener
    {
    void ClickedAt(Vector3 Position);
    }

[System.Serializable]
public class LocationClickEvent : UnityEvent<Vector3>
    {

    }

public class ClickLocationEventScript : MonoBehaviour {

    private List<IListener> _listeners = new List<IListener>();

    [SerializeField] private LocationClickEvent _clickEvent;

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
                _clickEvent.Invoke(hit.point);
                }
            }
	}

    public void AddListener(IListener listener)
        {
        _listeners.Add(listener);
        }
}
