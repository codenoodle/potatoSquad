using UnityEngine;
using System.Collections;

public class firearm : MonoBehaviour
{
	public Rigidbody bulletPrefab;
	public Transform barrelEnd;
	public AudioClip firesound;
	public AudioClip cannotFire;
	public AudioClip reload;
	public int bulletSpeed = 3000;
	public float reloadSpeed = 4f;
	private bool canShoot = true;
	private float lastShot = 0f;
	private bool soundWait = true;
	
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
				if(canShoot)
				{
					Rigidbody bulletInstance;
					bulletInstance = Instantiate(bulletPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
					bulletInstance.AddForce(barrelEnd.forward * bulletSpeed);
					audio.PlayOneShot(firesound);
					lastShot = Time.time + reloadSpeed;
					canShoot = false;
				} else {

				audio.PlayOneShot(cannotFire);

				}

		
		}
		if (lastShot <= Time.time + 0.67 && canShoot == false && soundWait == true) {
			audio.PlayOneShot(reload);
			soundWait = false;
		}
		if(lastShot <= Time.time && canShoot == false)
		{
			canShoot = true;
			soundWait = true;
		}

	}
}