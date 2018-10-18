using UnityEngine;
using System.Collections;

public class PencilGenractor : MonoBehaviour {

	// Use this for initialization
	public GameObject pencilPrefab;
	float span=2.0f;
	float delta=0;

	// Update is called once per frame
	void Update () {

		this.delta += Time.deltaTime;
		if (this.delta > this.span) {
			this.delta = 0;
			GameObject go = Instantiate (pencilPrefab) as GameObject;
			int px = Random.Range (-5, 5);
			go.transform.position = new Vector3 (px, 26, 0);
		}
	}
}
