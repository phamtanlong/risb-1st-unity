using UnityEngine;
using System.Collections;
using System.Diagnostics;
using UnityEditor;

public class test : MonoBehaviour {
    /*void Update() {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -Vector3.up, out hit))
		{
			
		}
    }
	
	public Texture2D aTexture;
    void OnGUI() {
		string texture = "Assets/2048.jpg";
		aTexture = (Texture2D)Resources.LoadAssetAtPath(texture, typeof(Texture2D));
        if (!aTexture) {
            UnityEngine.Debug.LogError("Assign a Texture in the inspector.");
            return;
        }
        GUI.DrawTexture(new Rect(0, 0, 1024, 683), aTexture, ScaleMode.ScaleToFit, true, 0.0F);
	}
	*/
	
	//GameObject target;
	
	int n = 0;
	void OnGUI() {
		print("TEST " + ++n);
		
		Handles.color = Color.red;
		Handles.ArrowCap(2, this.transform.position, this.transform.rotation, 10);
	}
	
}