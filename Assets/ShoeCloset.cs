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
	
	void Start () {
//		foreach (var drawer in drawers) {
//			drawer.open ();
//		}
	}
}
