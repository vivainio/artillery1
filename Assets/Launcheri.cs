using UnityEngine;
using System.Collections;

public class Launcheri : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var c = GameObject.Find ("Cube");
		Debug.Log ("hello world" + c);
		c.rigidbody.AddForce (new Vector3 (200, 200));

	
	}
	
	// Update is called once per frame
	void Update () {
		var c = GameObject.Find ("Cube");



		var inp = Input.GetMouseButtonDown (0);
		if (inp) {
			//c.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
			var v = c.rigidbody.velocity;
			c.rigidbody.AddForce( new Vector3(-400, 600));

			Debug.Log ("Pressed! " + v);

		}


	
	}
	
	void OnCollisionEnter(Collision collision) {
		var c = GameObject.Find ("Cube");
		c.rigidbody.AddExplosionForce (800, c.transform.position, 800);
		//var cyl = GameObject.Find ("Cylinder");
		//cyl.rigidbody.AddForce(new Vector2(900, 900));
		Debug.Log ("collision");


	}
	
}
