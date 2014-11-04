using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

	// Default pos
	public Vector3 PersonalPlayerLastPosition = new Vector3(1000f,1000f,1000f);

	// DEV 
	public bool spotPlayerNow = false;

	private gameController game;
	private lastPlayerSighting globalPlayerSighting;
	private GameObject player;
	private NavMeshAgent navAgent;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		globalPlayerSighting = GetComponent<lastPlayerSighting> ();
		navAgent = GetComponent<NavMeshAgent> ();
	}
	// Update is called once per frame
	void Update () {
	
		 // Check if Player has been spotted
		if (globalPlayerSighting.position != globalPlayerSighting.resetPosition) {
				// Player has been spotted
			PersonalPlayerLastPosition = globalPlayerSighting.position;
			navAgent.SetDestination(PersonalPlayerLastPosition);
		}

		if (spotPlayerNow) {
			PersonalPlayerLastPosition = player.transform.position;
			spotPlayerNow = false;
		}


	}
}
