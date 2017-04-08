using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour {

	private static int OPEN_BOOL_HASH = Animator.StringToHash("Open");

	private Animator anim;

	public void open() {
		anim.SetBool (OPEN_BOOL_HASH, true);
	}

	public void close() {
		anim.SetBool (OPEN_BOOL_HASH, false);
	}

	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
