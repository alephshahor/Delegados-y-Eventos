using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holyCubeLogic : MonoBehaviour {

	private int massIncrement = 100;

	void OnCollisionEnter(Collision collision){
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		spaceshipLogic spaceshipLogicScript = player.GetComponent<spaceshipLogic>();
		spaceshipLogicScript.playerPower = increasePower;
	  spaceshipLogicScript.playerPower();
	}

	void increasePower(){
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		player.GetComponent<Rigidbody>().mass += massIncrement;
	}
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
