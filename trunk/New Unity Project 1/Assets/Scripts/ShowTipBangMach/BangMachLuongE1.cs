using UnityEngine;
using System.Collections;

public class BangMachLuongE1 : MonoBehaviour {

	//Bảng mạch luồng E1

	GUIStyle labelStyle; //show text
	bool isShow = false; 
	string tip = "Bảng mạch luồng E1";
	
	void Start() {
		labelStyle = new GUIStyle();
		labelStyle.fontSize = 20;
		labelStyle.normal.textColor = Color.blue;
		labelStyle.alignment = TextAnchor.MiddleCenter;
	}
	
	void OnGUI() {
	if (isShow == true)
		GUI.Label(new Rect(Screen.width/2, Screen.height/2 + 200, 100, 20), tip, labelStyle);
    }
		
	void OnMouseEnter() {
		isShow = true;
	}
	
	void OnMouseExit() {
		isShow = false;
	}
}
