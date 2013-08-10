using UnityEngine;
using System.Collections;

public class _75Power1 : MonoBehaviour {

	//LED chỉ thị nguồn 75 VAC của CARD POWER 1
	
		GUIStyle labelStyle; //show text
		bool isShow = false; 
		string tip = "LED chỉ thị nguồn 75 VAC của CARD POWER 1";
		
		void Start() {
			labelStyle = new GUIStyle();
			labelStyle.fontSize = 20;
			labelStyle.normal.textColor = Color.blue;
			labelStyle.alignment = TextAnchor.MiddleCenter;
			
			
			
		}
		
		void Update() {
			//detect mouse movement
			if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0) {
				isShow = false;
			}
		}
		
		void OnGUI() {
			
			if (isShow == true)
				GUI.Label(new Rect(Screen.width/2, Screen.height/2 + 200, 100, 20), tip, labelStyle);
	    }
		
		void OnMouseOver() {
			isShow = true;
		}
}
