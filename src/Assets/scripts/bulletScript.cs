using UnityEngine;
using System.Collections;

public class bulletScript : MonoBehaviour
{
	public AudioClip impact;
	void OnTriggerEnter(Collider other) {
		AudioSource.PlayClipAtPoint(impact, transform.position, 0.5f);
		Destroy (gameObject);
		Debug.Log ("impact");
	}
	void Start()
	{
		Destroy (gameObject, 8f);
	}
}