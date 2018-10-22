using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class Eatfish2 : MonoBehaviour {
	GameObject cat;
	// Use this for initialization
	void Start () {
		this.cat=GameObject.Find("cat");
	}

	// Update is called once per frame
	void Update () {

		GameObject director = GameObject.Find ("PlayerController1");

	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.Equals (cat)) {
			GetComponent<AudioSource>().Play();
			Destroy (gameObject,0.2f);

			cat.GetComponent<PlayerController1> ().FishJump ();
		}
	}
}