using UnityEngine;
using System.Collections;

public class bulletScript : MonoBehaviour
{
	void Start()
	{
		Destroy (gameObject, 3.5f);
	}
}