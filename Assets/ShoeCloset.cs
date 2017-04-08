using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoeCloset : MonoBehaviour {

	private List<Drawer> drawers;

	// Use this for initialization
	void Awake () {
		drawers = new List<Drawer> ();

		drawers.Add (transform.Find ("Drawer1").gameObject.GetComponent<Drawer> ());
		drawers.Add (transform.Find ("Drawer2").gameObject.GetComponent<Drawer> ());
		drawers.Add (transform.Find ("Drawer3").gameObject.GetComponent<Drawer> ());
	}

	void Update () {
		if (Input.GetKeyDown ("1"))
			drawers [0].toggle ();
		if (Input.GetKeyDown ("2"))
			drawers [1].toggle ();
		if (Input.GetKeyDown ("3"))
			drawers [2].toggle ();
	}
}
