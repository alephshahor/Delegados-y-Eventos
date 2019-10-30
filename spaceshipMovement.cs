using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceshipMovement : MonoBehaviour {

	private Rigidbody rg;
	public float movementSpeed;
	public float rotationSpeed;

	// Use this for initialization
	void Start () {
		rg = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
			rg.AddForce(Vector3.forward  * movementSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.S))
			rg.AddForce(Vector3.back  * movementSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.A))
			rg.AddForce(Vector3.left * movementSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.D))
			rg.AddForce(Vector3.right  * movementSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.UpArrow)){
			rg.AddTorque(Vector3.left * rotationSpeed * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.DownArrow)){
			rg.AddTorque(Vector3.right * rotationSpeed * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.LeftArrow)){
			rg.AddTorque(Vector3.forward * rotationSpeed * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.RightArrow)){
			rg.AddTorque(Vector3.back * rotationSpeed * Time.deltaTime);
		}


	}
}
