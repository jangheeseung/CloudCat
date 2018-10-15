using UnityEngine;
using System.Collections;

public class CloudMove_up : MonoBehaviour {

	int up;
	// Use this for initialization
	void Start () {
		up = 1;
	}

	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (0.0f, 0.05f*up, 0.0f);
		if (transform.position.y > 13.0f) {
			up = -1;
		}
		if (transform.position.y < 8.5f) {
			up = 1;
		}
	}
}
