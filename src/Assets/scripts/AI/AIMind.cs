using UnityEngine;
using System.Collections;

public class AIMind : MonoBehaviour {

	private lastPlayerSighting lastPlayerSighting;
	private GameObject player;




	void Awake()
	{
		// Get components

		lastPlayerSighting = GetComponent<lastPlayerSighting> ();
		player = GameObject.FindGameObjectWithTag ("Player");


	}






	// Returns players current position
	public Vector3 getPlayerPos()
	{
		return player.transform.position;
	}

	// Returns last known position of player
	public Vector3 getLastKnownPlayerPos()
	{
		return lastPlayerSighting.position;
	}

	// Returns the current reset position
	public Vector3 getResetPosition()
	{
		return lastPlayerSighting.resetPosition;
	}




}
