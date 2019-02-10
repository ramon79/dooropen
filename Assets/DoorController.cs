using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {

	public GameObject Door;

	public bool doorIsOpening;

	void OnMouseDown()
	{
		doorIsOpening = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(doorIsOpening == true)
		{
			Door.transform.Translate (Vector3.up * Time.deltaTime);

		}
		if(Door.transform.position.y > 7f)
		{
			doorIsOpening = false;
	    }
	}
		

}
