using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class GlobalMenuFont : MonoBehaviour {

	public const int NUMBEROFFONTS = 6;

	public int fontChoice;
	private GUIStyle HOMOARAK;
	private GUIStyle NUROPOLX;
	private GUIStyle NUROPOLITICAL;
	private GUIStyle NEWBRILLIANT;
	private GUIStyle STRASUA;
	private GUIStyle XIROD;
	public GUIStyle[] FONTS = new GUIStyle[NUMBEROFFONTS];

	public void setFontChoice(float x){
		if (x >= 0 && x < NUMBEROFFONTS) {
			fontChoice = Mathf.RoundToInt(x);

		}
	}

	public Font GetFont(){
		return FONTS [fontChoice].font;
	}


	void Start(){
		fontChoice = 0;
		HOMOARAK = new GUIStyle();
		HOMOARAK.font = (Font)Resources.Load ("HOMOARAK");
		FONTS [0] = HOMOARAK;
		NUROPOLX = new GUIStyle();
		NUROPOLX.font = (Font)Resources.Load ("neuropol x rg");
		FONTS [1] = NUROPOLX;
		NUROPOLITICAL = new GUIStyle();
		NUROPOLITICAL.font = (Font)Resources.Load ("neuropolitical rg");
		FONTS [2] = NUROPOLITICAL;
		NEWBRILLIANT = new GUIStyle();
		NEWBRILLIANT.font = (Font)Resources.Load ("new brilliant");
		FONTS [3] = NEWBRILLIANT;
		STRASUA = new GUIStyle();
		STRASUA.font = (Font)Resources.Load ("strasua");
		FONTS [4] = STRASUA;
		XIROD = new GUIStyle();
		XIROD.font = (Font)Resources.Load ("xirod");
		FONTS [5] = XIROD;


		Debug.Log (HOMOARAK.font);
		Debug.Log (NUROPOLX.font);
	}
}
