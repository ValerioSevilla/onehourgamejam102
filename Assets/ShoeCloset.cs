using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShoeCloset : MonoBehaviour {

	private List<Drawer> drawers;
	private List<bool> toggled;

	// Use this for initialization
	void Awake () {
		drawers = new List<Drawer> ();

		drawers.Add (transform.Find ("Drawer1").gameObject.GetComponent<Drawer> ());
		drawers.Add (transform.Find ("Drawer2").gameObject.GetComponent<Drawer> ());
		drawers.Add (transform.Find ("Drawer3").gameObject.GetComponent<Drawer> ());

		toggled = new List<bool>{ false, false, false };
	}
	
	void Start () {

	}

	void Update () {
		
		if (Input.GetKeyDown ("1")) {
			toggled [0] = drawers [0].toggle ();
		}
		if (Input.GetKeyDown ("2")) {
			toggled [1] = drawers [1].toggle ();
		}
		if (Input.GetKeyDown ("3")) {
			toggled [2] = drawers [2].toggle ();
		}

		if (toggled [0] && toggled[1] && toggled[2])
			SceneManager.LoadScene (1);
	}
}
