using UnityEngine;
using System.Collections;

public class MoveShift : MonoBehaviour {
	float mSpeed = 3.0f; // Scale. Speed of the movement
	float lastX;
	float lastY;
	
	bool lastMouseIsDown = false;
	
	void Start() {
		lastX = Input.mousePosition.x;
		lastY = Input.mousePosition.y;
	}
	
	void LateUpdate () {
		if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) //shift
		{
			if((Input.GetMouseButton(0) && Input.GetMouseButton(1)) //mouse down (left+right)
				||
				Input.GetMouseButton(2)) //mouse down (middle)
			{
				if(lastMouseIsDown == false)
				{
					lastMouseIsDown = true;
					lastX = Input.mousePosition.x;
					lastY = Input.mousePosition.y;
					return;
				}
				else
				{
					float dx = Input.mousePosition.x - lastX;
					float dy = Input.mousePosition.y - lastY;
					
			      	transform.position -= transform.right * dx * Time.deltaTime * mSpeed;
			      	transform.position -= transform.up * dy * Time.deltaTime * mSpeed;
					
					lastX = Input.mousePosition.x;
					lastY = Input.mousePosition.y;
				}
			}
			else
			{
				lastMouseIsDown = false;
			}
		}
	}
}
