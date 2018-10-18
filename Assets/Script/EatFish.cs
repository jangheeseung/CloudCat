using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
public class EatFish : MonoBehaviour {
	GameObject cat;
	// Use this for initialization
	void Start () {
		this.cat=GameObject.Find("cat");
	}
	
	// Update is called once per frame
	void Update () {
	

			
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.Equals (cat)) {
			GetComponent<AudioSource>().Play();
			Destroy (gameObject,0.2f);
		}
	}
}
