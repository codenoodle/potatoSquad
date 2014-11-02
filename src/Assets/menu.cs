using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	public void startGame() {
		Application.LoadLevel ("characterMovement_DEV");
		}

	public void quitGame() {
		Application.Quit ();
}

}