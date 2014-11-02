using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

		// Vars
		private 	float 		movementSpeed;
		private 	AudioClip   jumpsound;
		private 	bool 		Grounded;

		// Modifyers
		private 	float 		WalkingModifier = 50f;
		private 	float		sprintModifier = 2f; // Default sprint modifier for movement
		private 	float		sprintSpeed = 1f;
		private 	float 		jumpModifier = 20f;

		// Triggers
	private GameObject collisionTrigger;
		

		void OnTriggerEnter(Collider other)
		{
		Debug.Log (other.name);
		}

		
		void Start()
	{
		collisionTrigger = GameObject.Find("playerCollisionTrigger");

		Collider test = collisionTrigger.collider;
		Debug.Log (test.isTrigger);
		Grounded = true;
	}



	/*

	void OnCollisionExit(Collision Collision) {
		// Player is in the air
		Debug.Log ("In air");
		Grounded = false;
		rigidbody.drag = 1;
	} 

	void OnCollisionEnter(Collision Collision) {
		// Player is touching the ground
		Grounded = true;
		Debug.Log ("Grounded");
		rigidbody.drag = 3;
	} 

	*/
	
	// Update is called once per frame
	void Update () 
		{

		
				bool forward = Input.GetButton ("Forward");
				bool backwards = Input.GetButton ("Backwards");
				bool left = Input.GetButton ("Left");
				bool right = Input.GetButton ("Right");
				bool jump = Input.GetButtonDown ("Jump");
				bool sprint = Input.GetButton ("Sprint");

				// if sprint is pressed the movement speed is altered
				if (sprint) {
						sprintSpeed = sprintModifier;
				} else {
						sprintSpeed = 1f;
				}
				
				if (Grounded) {
						movementSpeed = WalkingModifier;
				} else {
						movementSpeed = WalkingModifier / 4;
				}
	
				if (forward) {
						rigidbody.AddForce (transform.forward * movementSpeed * sprintSpeed, ForceMode.Force);
				}


				if (backwards) {
						rigidbody.AddForce (-transform.forward * movementSpeed * sprintSpeed, ForceMode.Force);
				}

				if (right) {
						rigidbody.AddForce (transform.right * movementSpeed * sprintSpeed, ForceMode.Force);
				}
		
				if (left) {
						rigidbody.AddForce (-transform.right * movementSpeed * sprintSpeed, ForceMode.Force);
				}
				if (jump && Grounded) {
						rigidbody.AddForce (transform.up * jumpModifier, ForceMode.VelocityChange);
						audio.PlayOneShot(jumpsound);
				}



		
	}
}
