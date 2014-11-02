using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

		// Vars
		private 	float 				movementSpeed;
		private 	AudioClip  			jumpsound;
		private 	bool 				Grounded = false;
		// Modifyers
		private 	float 				WalkingModifier = 50f;
		private 	float				sprintModifier = 2f; // Default sprint modifier for movement
		private 	float				sprintSpeed = 1f;
		private 	float 				jumpModifier = 20f;
		


	void OnTriggerEnter(Collider other) {
		Grounded = true;
	}

	void OnTriggerExit(Collider other) {
		Grounded = false;
	}
	
	
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
			Debug.Log ("Grounded");
				} else {
						movementSpeed = WalkingModifier / 3.5f;
			Debug.Log ("Airborne");
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
			if (jump ) {
						rigidbody.AddForce (transform.up * jumpModifier, ForceMode.VelocityChange);
						audio.PlayOneShot(jumpsound);
				}
	
	}
}
