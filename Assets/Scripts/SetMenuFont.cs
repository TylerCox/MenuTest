using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SetMenuFont : MonoBehaviour {

	private GameObject menuCanvas;
	

	// Use this for initialization
	void Start () {
		menuCanvas = GameObject.Find ("MenuCanvas");
		//Debug.Log(menuCanvas.GetComponent<GlobalMenuFont>().font);
		//Debug.Log (gameObject.GetComponent<Text> ().font);
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Text> ().font = 
			menuCanvas.GetComponent<GlobalMenuFont> ().GetFont ();	
	}
}
