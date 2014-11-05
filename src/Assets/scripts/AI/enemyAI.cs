using UnityEngine;
using System.Collections;

public class enemyAI : MonoBehaviour {

	// Default pos
	public Vector3 PersonalPlayerLastPosition = new Vector3(1000f,1000f,1000f);

	private GameObject AImaster;
	private AIMind Mind;
	private NavMeshAgent navAgent;
	private SphereCollider sphere; 

	void Awake()
	{
		AImaster = GameObject.FindGameObjectWithTag ("GameController");
		Mind = AImaster.GetComponent<AIMind> ();
		navAgent = GetComponent<NavMeshAgent> ();
		sphere = GetComponent<SphereCollider> ();
	}

	// Check if player is in sphere
	private void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player") {

			// Player is in collider
			PersonalPlayerLastPosition = other.transform.position;
			Debug.Log("There he is !");
		}
	}



	// Update is called once per frame
	void Update () {
	
		// Check if Player has been spotted by me
		if (PersonalPlayerLastPosition != Mind.getResetPosition()) {
			// Player has been spotted by another enemy and now we run to it
			moveToPos(PersonalPlayerLastPosition);
		}

		 // Check if Player has been spotted at any other enemys
		if (Mind.getLastKnownPlayerPos() != Mind.getResetPosition()) {
			// Player has been spotted by another enemy and now we run to it

			PersonalPlayerLastPosition = Mind.getLastKnownPlayerPos();
			moveToPos(PersonalPlayerLastPosition);

		}
		


	}


	private void moveToPos(Vector3 pos)
	{
		navAgent.SetDestination (pos);
	}



}
