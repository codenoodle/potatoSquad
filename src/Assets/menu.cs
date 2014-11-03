using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {
	void Start(){
		Screen.showCursor = true;
	}
	public void startGame() {
		Application.LoadLevel ("playtest_DEV");
		}

	public void quitGame() {
		Application.Quit ();
}

}