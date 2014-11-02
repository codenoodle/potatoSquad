using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {



		public float 		WalkingModifier = 50f;
			   float movementSpeed;
		public float		sprintModifier = 2f; // Default modifier for movement
			   float		sprintSpeed = 1f;
		public float 		jumpModifier = 20f;
		public AudioClip    jumpsound;
		       bool 		Grounded;
	

	void OnCollisionExit(Collision Collision) {
		Debug.Log ("In air");
		Grounded = false;
		rigidbody.drag = 1;
	} 

	void OnCollisionEnter(Collision Collision) {
		Grounded = true;
		Debug.Log ("Grounded");
		rigidbody.drag = 3;
	} 

	
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
