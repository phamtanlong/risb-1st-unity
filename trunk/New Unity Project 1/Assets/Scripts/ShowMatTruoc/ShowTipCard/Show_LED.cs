using UnityEngine;
using System.Collections;


	public class Show_LED: MonoBehaviour {
		
		GUIStyle labelStyle; //show text
		bool isShow = false; 
		string tip = "Màn hình để hiển thị (ngày/tháng hay giờ/phút) " + "\n" +
			"hoặc hiển thị các thuê bao tham số trung kế khi sử dụng các lệnh hiển thị";
		
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