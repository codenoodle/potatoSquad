using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	public void startGame() {
		Application.LoadLevel ("jaf_DEV");
		}

	public void quitGame() {
		Application.Quit ();
}

}