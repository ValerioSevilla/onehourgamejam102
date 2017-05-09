using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			SceneManager.LoadScene ("MainScene");
		}
	}
}
