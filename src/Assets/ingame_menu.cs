using UnityEngine;
using System.Collections;

public class ingame_menu : MonoBehaviour {


	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Escape)){
			Application.LoadLevel ("menu");
	}
}

}
