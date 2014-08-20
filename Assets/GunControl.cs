using UnityEngine;
using System.Collections;

public class GunControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		var k = Input.GetKey (KeyCode.A);
		if (k) {
			Debug.Log("A pressed");
			
		}
	
	}

	void FixedUpdate() {

	}

}
