using UnityEngine;
using System.Collections;

public class ZoomShift : MonoBehaviour {

	float limitInfer = 5;
	float limitSuper = 100;
	float speedRotate = 30; //the speedRotate of zoom
	float speedMouse = 3;
	float lastY;
	float lastWheel;
	
	void Start() {
		lastY = Input.GetAxis("Mouse Y");
		lastWheel = Input.GetAxis("Mouse ScrollWheel");
	}
	
	void Update ()
	{
		if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
		{
			//0: left, 1: right, 2: middle
			if(Input.GetMouseButton(1) && !Input.GetMouseButton(0)) {
	        	float y = Input.GetAxis("Mouse Y");
				float dy = y - lastY;
				
				Camera.main.fieldOfView += speedMouse * dy;
			} 
			else
			{
				float wheel = Input.GetAxis("Mouse ScrollWheel");
				float dw = wheel - lastWheel;
				Camera.main.fieldOfView += speedRotate * dw;
			}
			
			if(Camera.main.fieldOfView < limitInfer)
				Camera.main.fieldOfView = limitInfer;
			
			if(Camera.main.fieldOfView > limitSuper)
				Camera.main.fieldOfView = limitSuper;
		}
	}
}
