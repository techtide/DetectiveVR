using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	private float i;
	
	// Update is called once per frame
	void Update ()
	{
		i += Time.deltaTime;

		Vector3 current = transform.eulerAngles;
		transform.eulerAngles = new Vector3(current.x, 138 + ((float)Math.Sin(i) * 30f), current.z);
	}
}
