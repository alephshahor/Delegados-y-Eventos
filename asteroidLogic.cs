using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidLogic : MonoBehaviour {

	private int massDecrement = 500;

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Player"){
			GameObject player = GameObject.FindGameObjectWithTag("Player");
			spaceshipLogic spaceshipLogicScript = player.GetComponent<spaceshipLogic>();
			spaceshipLogicScript.playerPower = decreasePower;
			spaceshipLogicScript.playerPower();
			transform.localScale *= 2;
		}

	}

	void decreasePower(){
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		Rigidbody playerRigidBody = player.GetComponent<Rigidbody>();
		if(playerRigidBody.mass > massDecrement){
			playerRigidBody.mass -= massDecrement;
		}else if(playerRigidBody.mass <= massDecrement){
			playerRigidBody.mass = 1;
		}

	}
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

}
