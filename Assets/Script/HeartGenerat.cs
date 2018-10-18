using UnityEngine;
using System.Collections;

public class HeartGenerat : MonoBehaviour {

	public GameObject heartPrefab;
	float span=5.0f;
	float delta=0;

	// Update is called once per frame
	void Update () {

		this.delta += Time.deltaTime;
		if (this.delta > this.span) {
			this.delta = 0;
			GameObject go = Instantiate (heartPrefab) as GameObject;
			int px = Random.Range (-5, 5);
			go.transform.position = new Vector3 (px, 26, 0);
		}
	}
}
