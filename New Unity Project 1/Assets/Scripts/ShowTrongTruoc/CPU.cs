using UnityEngine;
using System.Collections;

public class CPU : MonoBehaviour {

	//Bảng mạch CPU
	
		GUIStyle labelStyle; //show text
		bool isShow = false; 
		string tip = "Bảng mạch CPU";
		
		void Start() {
			labelStyle = new GUIStyle();
			labelStyle.fontSize = 20;
			labelStyle.normal.textColor = Color.blue;
			labelStyle.alignment = TextAnchor.MiddleCenter;
		}
		
		void OnGUI() {
			
			if (isShow == true)
				GUI.Label(new Rect(Screen.width/2, Screen.height/2 + 260, 100, 20), tip, labelStyle);
	    }
		
		void OnMouseOver() {
			isShow = true;
			}
	
		void OnMouseExit() {
			isShow = false;
		}
}
