using UnityEngine;
using System.Collections;

public class MainGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Object.DontDestroyOnLoad
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI () {
		GUI.Label (new Rect (400, 400, 200, 100), "Menu");
		
		// Make a background box
		GUI.Box(new Rect(10,10,200,200), "Cấu tạo tủ tổng đài");
		
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20, 40, 150,20), "START")) {
			print ("Click: START");
			
			Application.LoadLevelAdditive("1");
		}
		

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20, 70, 150,20), "Xem tổng thể")) {
			print ("Click: Xem tổng thể");
			
			Application.LoadLevel("GUI");
			Application.LoadLevelAdditive("1");
		}

		// Make the second button.
		if(GUI.Button(new Rect(20, 100, 150,20), "Xem mặt trước")) {
			print ("Click: Xem mặt trước");
			
			Application.LoadLevel("GUI");
			Application.LoadLevelAdditive("MatTruoc");
		}
	}
}
