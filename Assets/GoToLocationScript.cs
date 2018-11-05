using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToLocationScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //get mouse position
        Vector3 mousePos = Input.mousePosition;
        Camera.main.ScreenPointToRay(mousePos);
	}
}
