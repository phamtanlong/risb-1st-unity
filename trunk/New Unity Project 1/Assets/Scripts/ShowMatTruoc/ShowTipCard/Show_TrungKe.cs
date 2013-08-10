using UnityEngine;
using System.Collections;

public class Show_TrungKe : MonoBehaviour {

	//LED Trung kế điều khiển từ xa
	
		GUIStyle labelStyle; //show text
		bool isShow = false; 
		string tip = "LED hiển thị trạng thái trung kế điều khiển từ xa";
		
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
