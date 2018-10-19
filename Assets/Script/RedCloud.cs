using UnityEngine;
using System.Collections;

public class RedCloud : MonoBehaviour {

	GameObject cat;
	// Use this for initialization
	void Start () {
		this.cat=GameObject.Find("cat");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionStay2D(Collision2D other)
	{
		if (other.gameObject.Equals (cat)) {
			GameObject director = GameObject.Find ("GameDirector");
			director.GetComponent<GameDirector> ().slowHP ();
		}
	}
}
