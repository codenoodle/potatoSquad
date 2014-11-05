using UnityEngine;
using System.Collections;

public class lastPlayerSighting : MonoBehaviour {

	public Vector3 position = new Vector3(1000f,1000f,1000f);
	public Vector3 resetPosition = new Vector3 (1000f, 1000f, 1000f);
	private GameObject player;

	// DEV 
	public bool spotPlayerNow = false;
	public bool chasePlayerNow = false;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		}


 void Update()
	{
		if (spotPlayerNow) {
			position = player.transform.position;
			spotPlayerNow = false;
		}

		if (chasePlayerNow) {
			position = player.transform.position;

		}

		}
}
