using UnityEngine;
using System.Collections;

public class BottleControl : MonoBehaviour {
	Rigidbody rb;
	bool touched = false;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 1 && touched == false)
			touched = true;
		else
			touched = false;
		if (touched || Input.GetMouseButtonDown(0)) {
			rb.AddForce (new Vector3 (0, 300, 0));
		}
	}
}
