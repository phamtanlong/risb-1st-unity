using UnityEngine;
using System.Collections;

public class _12Power2 : MonoBehaviour {

	//LED chỉ thị nguồn +12 VAC của CARD POWER 2
	
		GUIStyle labelStyle; //show text
		bool isShow = false; 
		string tip = "LED chỉ thị nguồn +12 VAC của CARD POWER 2";
		
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
