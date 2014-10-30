using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		bool forward 	= Input.GetButton("Forward");
		bool backwards 	= Input.GetButton("Backwards");
		bool left 		= Input.GetButton("Left");
		bool right 		= Input.GetButton("Right");
		bool sprint 	= Input.GetButton("Sprint");
		int MovementModifyer = 50;


		int sprintModifyer = 1; // Default modifyer for movement

		// if sprint is pressed the movement speed is altered
		if (sprint) { sprintModifyer = 2;} 
	
		if (forward)
		{
			rigidbody.AddForce(transform.forward * MovementModifyer * sprintModifyer, ForceMode.Acceleration);
			rigidbody.useGravity = true;
		}

		if (backwards)
		{
			rigidbody.AddForce(-transform.forward * MovementModifyer * sprintModifyer, ForceMode.Acceleration);
			rigidbody.useGravity = true;
		}

		if (right)
		{
			rigidbody.AddForce(transform.right * MovementModifyer * sprintModifyer, ForceMode.Acceleration);
			rigidbody.useGravity = true;
		}
		
		if (left)
		{
			rigidbody.AddForce(-transform.right * MovementModifyer * sprintModifyer, ForceMode.Acceleration);
			rigidbody.useGravity = true;
		}


	}
}
