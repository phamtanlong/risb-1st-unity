using UnityEngine;
using System.Collections;

public class Power2 : MonoBehaviour {

	//LED (sang) chi thi CARD POWER 2 dang su dung
	
		GUIStyle labelStyle; //show text
		bool isShow = false; 
		string tip = "LED (sáng) chỉ thị CARD POWER 2 đang sử dụng";
		
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
		
	void OnMouseEnter() {
		isShow = true;
	}
	
	void OnMouseExit() {
		isShow = false;
	}
}
