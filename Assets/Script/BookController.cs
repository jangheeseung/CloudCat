using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

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
			
	}


	void OnTriggerEnter2D (Collider2D other)
	{
		GameObject flag = GameObject.Find ("cat");

		if (other.gameObject.Equals (cat)) {
		
	//		GetComponent<AudioSource>().Play();
			Destroy (gameObject);

			GameObject director = GameObject.Find ("GameDirector");
			director.GetComponent<GameDirector> ().DecreaseHP ();
		}
	}
}
