﻿using UnityEngine;
using System.Collections;

public class BlueCloud : MonoBehaviour {

	int back;

	// Use this for initialization
	void Start () {
		back = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position += new Vector3 (0.02f*back, 0.0f, 0.0f);
		if (transform.position.x > -0.15f) {
			back = -1;
		}
		if (transform.position.x < -4.5f) {
			back = 1;
		}
	}
}