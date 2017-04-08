using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour {

	private static int OPEN_BOOL_HASH = Animator.StringToHash("Open");

	private Animator anim;

	public GameObject BlackShoePrefab;
	public GameObject RedShoePrefab;
	public GameObject BlueShoePrefab;
	public GameObject WhiteShoePrefab;

	private List<GameObject> Shoes;

	public void open() {
		anim.SetBool (OPEN_BOOL_HASH, true);
	}

	public void close() {
		anim.SetBool (OPEN_BOOL_HASH, false);
	}

	public void randomize() {
		foreach (var shoe in Shoes) {
			Destroy (shoe);
		}

		for (int i = 0; i < 3; ++i) {
			int _random = Random.Range (1, 5);
			GameObject shoe;
			switch (_random) {
			case 1:
				shoe = Instantiate (BlackShoePrefab);
				break;
			case 2:
				shoe = Instantiate (RedShoePrefab);
				break;
			case 3:
				shoe = Instantiate (BlueShoePrefab);
				break;
			case 4:
				shoe = Instantiate (WhiteShoePrefab);
				break;
			default:
				shoe = Instantiate (BlackShoePrefab);
				break;
			}

			shoe.transform.Rotate(new Vector3 (
				-90.0f,
				0.0f,
				180.0f
			));
			shoe.transform.localPosition = new Vector3 (
				-0.35f + (0.35f * i),
				0.25f,
				0.075f
			);
			shoe.transform.localScale = shoe.transform.localScale * 0.75f;

			shoe.transform.SetParent (transform, false);
		}
			
	}

	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator> ();
		Shoes = new List<GameObject> ();
		randomize ();
	}
}
