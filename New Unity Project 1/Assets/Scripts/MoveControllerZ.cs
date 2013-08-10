
using UnityEngine;
using System.Collections;


[RequireComponent(typeof(MeshCollider))]
public class MoveControllerZ : MonoBehaviour 
{
	//reference
	public MoveControllerXY nap;
	public bool itCanMove = false;
	
	public bool isInFirstTime = true;
	public bool isOutside = false;
	//
	
	private float MIN_Z = -15;
	private bool isFirstTime = true;
	private Vector3 startPosition;
	
	private bool enableMove = true;	
	private Vector3 mouseLastPoint;
	
	void OnMouseDown()
	{
		if(nap.transform.position.y < 3.1f &&
			nap.transform.position.x > -6.5f)
		{
			enableMove = false;
		} 
		else 
		{
			enableMove = true;
			
			if(isFirstTime == true) {
				isFirstTime = false;
				startPosition = transform.position;
			}
			
			if(enableMove) {
				mouseLastPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
			}
		}
	}
	
	void OnMouseDrag()
	{
		if(enableMove) {
			Vector3 mouseCurrentPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
			Vector3 delta = mouseCurrentPoint - mouseLastPoint;
			
			Vector3 position = transform.position;
			position.z += 0.03f * delta.x;
			isInFirstTime = false;
			isOutside = false;
			
			if(position.z >= startPosition.z) {
				position.z = startPosition.z;
				isInFirstTime = true;
			}
			
			if(position.z < MIN_Z) {
				position.z = MIN_Z;
			}
			
			transform.position = position;
			mouseLastPoint = mouseCurrentPoint;
			
			itCanMove = (isInFirstTime || isOutside);
		}
	}
}