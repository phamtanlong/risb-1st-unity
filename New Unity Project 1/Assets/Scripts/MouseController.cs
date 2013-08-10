using UnityEngine;
using System.Collections;

public class MouseController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	int n = 0;
	void OnMouseDown() {
		print("MOUSE DOWN  " + ++n);
	}
}
