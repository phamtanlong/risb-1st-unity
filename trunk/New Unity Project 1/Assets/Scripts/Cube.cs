using UnityEngine;
using System.Collections;
using System.Diagnostics;
using System.IO;

public class Cube : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown() {
		print ("CLick");
		print (Directory.GetCurrentDirectory() + "\\ThaoLapT64S\\module1.exe");
		Process.Start(Directory.GetCurrentDirectory() + "\\ThaoLapT64S\\module1.exe");
	}
}
