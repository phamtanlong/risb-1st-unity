using UnityEngine;
using System.Collections;

public class ZoomObject : MonoBehaviour {

	int limitInfer = 2;
	int limitSuper = 100;
	int speed = 5; //the speed of zoom
	
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetAxis("Mouse ScrollWheel") > 0 && Camera.main.fieldOfView > limitInfer)
		{		
			Camera.main.fieldOfView -= speed;
		}
		
		if(Input.GetAxis("Mouse ScrollWheel") < 0 && Camera.main.fieldOfView < limitSuper)
		{
			
			Camera.main.fieldOfView += speed;
		}
	}
}
