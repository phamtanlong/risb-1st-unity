using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour
{
	
	public GUIStyle logoStyle;
	public Texture2D logo;
	
	void OnGUI ()
	{
		//logo truong
		GUI.Box (new Rect (45, 0, 90, 90), "", logoStyle);
				
		#region Cau tao tu tong dai
		// Group Cấu tạo tủ tổng đài
		GUI.Box (new Rect (10, 110, 170, 160), "CẤU TẠO TỦ TỔNG ĐÀI");

		// Tổng thể
		if (GUI.Button (new Rect (20, 140, 150, 20), "Tổng thể")) {
			Application.LoadLevel (1);
		}

		// Mặt trước
		if (GUI.Button (new Rect (20, 165, 150, 20), "Mặt trước")) {
			Application.LoadLevel (2);
		}
		
		//Mặt trong
		if (GUI.Button (new Rect (20, 190, 150, 20), "Mặt trong")) {
			Application.LoadLevel (3);
		}
		
		//Khung tủ
		if (GUI.Button (new Rect (20, 215, 150, 20), "Khung tủ")) {
			Application.LoadLevel (4);
		}
		
		//Mặt sau
		if (GUI.Button (new Rect (20, 240, 150, 20), "Mặt sau")) {
			Application.LoadLevel (5);
		}
		#endregion
		
		
		#region Cau tao bang mach
		// Group Cấu tạo bảng mạch
		GUI.Box (new Rect (10, 275, 170, 160), "CẤU TẠO BẢNG MẠCH");
		
		//Bảng mach CPU
		if (GUI.Button (new Rect (20, 305, 150, 20), "Mặt sau")) {
			Application.LoadLevel (6);
		}
		
		//Bảng mach luồng E1
		if (GUI.Button (new Rect (20, 330, 150, 20), "Bảng mạch luồng E1")) {
			Application.LoadLevel (7);
		}
		
		//Bảng mach thuê bao
		if (GUI.Button (new Rect (20, 355, 150, 20), "Bảng mạch thuê bao")) {
			Application.LoadLevel (8);
		}
		
		//Bảng mach CO, ĐKX
		if (GUI.Button (new Rect (20, 380, 150, 20), "Bảng mạch CO, ĐKX")) {
			Application.LoadLevel (9);
		}
		
		//Bảng mạch nguồn
		if (GUI.Button (new Rect (20, 405, 150, 20), "Bảng mạch nguồn")) {
			Application.LoadLevel (10);
		}
		#endregion
		
		
		#region Khai thác và sử dụng
		// Group KHAI THAC VA SU DUNG
		GUI.Box (new Rect (10, 440, 170, 105), "KHAI THÁC VÀ SỬ DỤNG");
		
		//Tháo lắp
		if (GUI.Button (new Rect (20, 465, 150, 20), "Tháo / Lắp")) {
			Application.LoadLevel (11);
		}
		
		//Đấu nối
		if (GUI.Button (new Rect (20, 490, 150, 20), "Đấu nối")) {
			Application.LoadLevel (12);
		}
		
		//Khai báo
		if (GUI.Button (new Rect (20, 515, 150, 20), "Khai báo")) {
			Application.LoadLevel (13);
		}
		#endregion
		
		// Group HUONG DAN SU DUNG
		GUI.Box (new Rect (10, 550, 170, 50), "HƯỚNG DẪN SỬ DỤNG");
		
		//Khai báo
		if (GUI.Button (new Rect (20, 575, 150, 20), "Hướng dẫn sử dụng")) {
			Application.LoadLevel (14);
		}
		
	}	
}
