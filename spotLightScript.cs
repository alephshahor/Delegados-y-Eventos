using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spotLightScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;

		if(Input.GetKeyDown(KeyCode.F)){
			GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
		}
	}
}
