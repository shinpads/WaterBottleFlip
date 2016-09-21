using UnityEngine;
using System.Collections;

public class BottleControl : MonoBehaviour {
	Rigidbody rb;
	bool touched = false;
	Vector3 curPos;
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
			curPos = transform.position;
			if (curPos.y < 2.5f) {
				rb.AddForce (new Vector3 (0, 1000, 0));
				rb.AddTorque (new Vector3 (400, 0, 0));
			}
		}
	}
}
