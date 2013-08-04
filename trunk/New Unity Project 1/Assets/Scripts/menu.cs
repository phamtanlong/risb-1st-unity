using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour
{
	
	//public GUIStyle boxStyle;
	
	void OnGUI ()
	{
		#region Cau tao tu tong dai
		// Group Cấu tạo tủ tổng đài
		GUI.Box (new Rect (10, 10, 170, 180), "CẤU TẠO TỦ TỔNG ĐÀI");

		// Tổng thể
		if (GUI.Button (new Rect (20, 40, 150, 20), "Tổng thể")) {
			Application.LoadLevel (1);
		}

		// Mặt trước
		if (GUI.Button (new Rect (20, 70, 150, 20), "Mặt trước")) {
			Application.LoadLevel (2);
		}
		
		//Mặt trong
		if (GUI.Button (new Rect (20, 100, 150, 20), "Mặt trong")) {
			Application.LoadLevel (3);
		}
		
		//Khung tủ
		if (GUI.Button (new Rect (20, 130, 150, 20), "Khung tủ")) {
			Application.LoadLevel (4);
		}
		
		//Mặt sau
		if (GUI.Button (new Rect (20, 160, 150, 20), "Mặt sau")) {
			Application.LoadLevel (5);
		}
		#endregion
		
		
		#region Cau tao bang mach
		// Group Cấu tạo bảng mạch
		GUI.Box (new Rect (10, 200, 170, 180), "CẤU TẠO BẢNG MẠCH");
		
		//Bảng mach CPU
		if (GUI.Button (new Rect (20, 230, 150, 20), "Mặt sau")) {
			Application.LoadLevel (6);
		}
		
		//Bảng mach luồng E1
		if (GUI.Button (new Rect (20, 260, 150, 20), "Bảng mạch luồng E1")) {
			Application.LoadLevel (6);
		}
		
		//Bảng mach thuê bao
		if (GUI.Button (new Rect (20, 290, 150, 20), "Bảng mạch thuê bao")) {
			Application.LoadLevel (6);
		}
		
		//Bảng mach CO, ĐKX
		if (GUI.Button (new Rect (20, 320, 150, 20), "Bảng mạch CO, ĐKX")) {
			Application.LoadLevel (7);
		}
		
		//Bảng mạch nguồn
		if (GUI.Button (new Rect (20, 350, 150, 20), "Bảng mạch nguồn")) {
			Application.LoadLevel (8);
		}
		#endregion
		
		
		#region Khai thác và sử dụng
		// Group KHAI THAC VA SU DUNG
		GUI.Box (new Rect (10, 390, 170, 120), "KHAI THÁC VÀ SỬ DỤNG");
		
		//Tháo lắp
		if (GUI.Button (new Rect (20, 420, 150, 20), "Tháo lắp")) {
			Application.LoadLevel (9);
		}
		
		//Đấu nối
		if (GUI.Button (new Rect (20, 450, 150, 20), "Đấu nối")) {
			Application.LoadLevel (10);
		}
		
		//Khai báo
		if (GUI.Button (new Rect (20, 480, 150, 20), "Khai báo")) {
			Application.LoadLevel (11);
		}
		#endregion
		
		// Group HUONG DAN SU DUNG
		GUI.Box (new Rect (10, 520, 170, 60), "HƯỚNG DẪN SỬ DỤNG");
		
		//Khai báo
		if (GUI.Button (new Rect (20, 550, 150, 20), "Hướng dẫn sử dụng")) {
			Application.LoadLevel (12);
		}
		
		
	}
}
