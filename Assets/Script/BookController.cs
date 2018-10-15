using UnityEngine;
using System.Collections;

public class BookController : MonoBehaviour {

	GameObject cat;
	// Use this for initialization
	void Start () {
		this.cat=GameObject.Find("cat");
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (0, -0.1f, 0);

		if (transform.position.y < -10.0f) {
			Destroy(gameObject);
		}

		Vector2 p1 = transform.position;
		Vector2 p2 = this.cat.transform.position;
		Vector2 dir = p1 - p2;
		float d = dir.magnitude;
		float r1 = 0.3f;
		float r2 = 0.5f;

		if (d < r1 + r2) {
			Destroy (gameObject);

			GameObject director = GameObject.Find ("GameDirector");
			director.GetComponent<GameDirector> ().DecreaseHP ();
		}
	}
}
