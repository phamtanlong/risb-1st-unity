using UnityEngine;
using System.Collections;

public class BangMachTrungKe : MonoBehaviour {

	//Bảng mạch trung kế CO, đkx

	GUIStyle labelStyle; //show text
	bool isShow = false; 
	string tip = "Bảng mạch trung kế CO, đkx";
	
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
