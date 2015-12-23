using UnityEngine;
using System.Collections;

public class EventosPausa : MonoBehaviour {

	bool paused = false;
	bool back = false;
	GameObject panemenu;
	GameObject doorToken;



	// Use this for initialization
	void Start () {

		Cursor.visible = false;
		Screen.lockCursor = true;
		//GameObject.Find ("XboxControl").GetComponent<XboxMouseControl> ().enabled = false;
		doorToken = GameObject.Find ("doortokens");
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp (KeyCode.Escape)) {
			paused = togglePaused ();
		}
		//if (Input.GetButtonDown ("360_Start")) {
		//	paused = togglePaused ();
		//}
	
	}

	bool togglePaused ()
	{
		if (paused) {
			if ( Application.loadedLevelName == "Main") {
				GameObject.Find ("Player").GetComponent<FirstControl> ().enabled = true;
				GameObject.Find ("Player").GetComponent<Mouselook> ().enabled = true;
				//GameObject.Find ("Player").GetComponent<Select> ().enabled = true;
				//GameObject.Find ("InputHandler").GetComponent<MostrarEtiquetas> ().enabled = true;
				//GameObject.Find ("InputHandler").GetComponent<cameraSwitch> ().enabled = true;
				//GameObject.Find ("camVistaTop").GetComponent<moveAxisCam> ().enabled = true;
				//GameObject.Find ("flyCam").GetComponent<moveAxisFlyCam> ().enabled = true;
				doorToken.SetActive (true);
			}
			//GameObject.Find ("XboxControl").GetComponent<XboxMouseControl> ().enabled = false;
			//panemenu.SetActive (false);
			if (!back) {
				Cursor.visible = false;
				Screen.lockCursor = true;				
			}
			return(false);
		} else {
			if ( Application.loadedLevelName == "Main") {
				GameObject.Find ("Player").GetComponent<FirstControl> ().enabled = false;
				GameObject.Find ("Player").GetComponent<Mouselook> ().enabled = false;
				//GameObject.Find ("Player").GetComponent<Select> ().enabled = false;
				//GameObject.Find ("InputHandler").GetComponent<MostrarEtiquetas> ().enabled = false;
				//GameObject.Find ("InputHandler").GetComponent<cameraSwitch> ().enabled = false;
				//GameObject.Find ("camVistaTop").GetComponent<moveAxisCam> ().enabled = false;
				//GameObject.Find ("flyCam").GetComponent<moveAxisFlyCam> ().enabled = false;
				doorToken.SetActive (false);
			}
			//GameObject.Find ("XboxControl").GetComponent<XboxMouseControl> ().enabled = true;
			//panemenu.SetActive (true);
			Cursor.visible = true;
			Screen.lockCursor = false;
			return(true);
		}
	}
}