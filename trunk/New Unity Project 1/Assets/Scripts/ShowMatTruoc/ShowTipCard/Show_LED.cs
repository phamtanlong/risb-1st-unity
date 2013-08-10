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
		
		int n = 0;
		
		
		
		void OnMouseOver() {
			isShow = true;
		}
	}