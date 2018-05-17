using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_Movement : MonoBehaviour {

	//! Create variables:
	int speed;

	// Use this for initialization
	void Start () {
		speed = 5;	
	}
	
	// Update is called once per frame
	void Update () {
		//! Forwards and back:
		if (Input.GetKey(KeyCode.W)){
			transform.Translate(-speed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey(KeyCode.S)){
			transform.Translate(speed * Time.deltaTime, 0, 0);
		}
		//! Strafing:
		if (Input.GetKey(KeyCode.A)){
			transform.Rotate(0, 0, -100 * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D)){
			transform.Rotate(0, 0, 100 * Time.deltaTime);
		}
	}
}