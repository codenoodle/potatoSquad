using UnityEngine;
using System.Collections;

public class firearm : MonoBehaviour
{
	public Rigidbody bulletPrefab;
	public Transform barrelEnd;
	public AudioClip firesound;
	public int bulletSpeed = 3000;
	
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
			Rigidbody bulletInstance;
			bulletInstance = Instantiate(bulletPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
			bulletInstance.AddForce(barrelEnd.forward * bulletSpeed);
			audio.PlayOneShot(firesound);
		}
	}
}