using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuScript : MonoBehaviour {

	public GameObject settingsMenu;
	public GameObject ExitMenu;
	public Button playText;
	public Button exitText;
	public Button settingsText;

	private bool SettingsPressed = false;
	private bool ExitPressed = false;
	// Use this for initialization
	void Start () {
		settingsMenu.gameObject.SetActive (false);
		ExitMenu.gameObject.SetActive (false);

		playText = playText.GetComponent<Button> ();
		settingsText = settingsText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();


	}
	
	public void SettingsPress(){
		ExitPressed = false;
		ExitMenu.gameObject.SetActive (ExitPressed);
		SettingsPressed = !SettingsPressed;
		settingsMenu.gameObject.SetActive (SettingsPressed);

	}

	public void ExitPress(){
		SettingsPressed = false;
		settingsMenu.gameObject.SetActive (SettingsPressed);
		ExitPressed = !ExitPressed;
		ExitMenu.gameObject.SetActive (ExitPressed);

	}

	public void ExitGame(){
		Application.Quit ();
	}
}
