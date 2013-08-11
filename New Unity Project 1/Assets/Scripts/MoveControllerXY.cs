

using UnityEngine;
using System.Collections;


[RequireComponent(typeof(MeshCollider))]
public class MoveControllerXY : MonoBehaviour 
{
	//reference
	public MoveControllerZ obj1;
	public MoveControllerZ obj2;
	public MoveControllerZ obj3;
	public MoveControllerZ obj4;
	public MoveControllerZ obj5;
	public MoveControllerZ obj6;
	public MoveControllerZ obj7;
	
	
	//
	private bool enableMove = true;
	private float RADIUS = 0.7f;
	private bool isNear = true;
	private bool isFirstTime = true;
	private Vector3 startPosition;
	private Vector3 mouseLastPoint;
	
	void OnMouseDown()
	{
		if(obj1.itCanMove &&
			obj2.itCanMove &&
			obj3.itCanMove &&
			obj4.itCanMove &&
			obj5.itCanMove &&
			obj6.itCanMove &&
			obj7.itCanMove) 
		{
			//print("it can move");
			enableMove = true;
			if(isFirstTime == true)
			{
				startPosition = transform.position;
				Vector3 position = transform.position;
				position.z -= 0.1f;
				transform.position = position;
				isFirstTime = false;
			}
			mouseLastPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
		}
		else 
		{
			//print("it can NOT move");
			enableMove = false;
		}
	}
	
	
	void OnMouseDrag()
	{
		if(enableMove) {
			Vector3 mouseCurrentPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
			Vector3 delta = mouseCurrentPoint - mouseLastPoint;
			
			transform.position += 0.02f * delta;
			
			float dx = transform.position.x - startPosition.x;
			float dy = transform.position.y - startPosition.y;
			if(Mathf.Abs(dx) <= RADIUS && Mathf.Abs(dy) <= RADIUS)
			{
				if(isNear == false)
				{
					isNear = true;
					transform.position = startPosition;
					isFirstTime = true;
					
					enableMove = false;
				}
			} else {
				isNear = false;	
			}
			
			mouseLastPoint = mouseCurrentPoint;
		}
		
		//print(transform.position);
	}
}