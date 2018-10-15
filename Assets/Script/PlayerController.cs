using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	Rigidbody2D rigid2d;
	Animator animator;
	float jumpforce = 680.0f;
	float walkForce=30.0f;
	float maxWalkSpeed=2.0f;
	GameObject player;
	GameObject flag;
	GameObject blackhall;

	// Use this for initialization
	void Start () {
		this.rigid2d = GetComponent<Rigidbody2D> ();
		this.animator = GetComponent<Animator> ();
	}
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton (0) && this.rigid2d.velocity.y == 0) {
			this.animator.SetTrigger ("JumpTrigger");
			this.rigid2d.AddForce (transform.up * jumpforce);
		}
		if (Input.GetKeyDown (KeyCode.Space)&&this.rigid2d.velocity.y==0) {
			this.rigid2d.AddForce (transform.up * this.jumpforce);
			GetComponent<AudioSource> ().Play ();
		}

		int key=0;
		if(Input.GetKey(KeyCode.RightArrow)) key =1;
		if(Input.GetKey(KeyCode.LeftArrow)) key =-1;

		float speedx=Mathf.Abs(this.rigid2d.velocity.x);

			if(speedx<this.maxWalkSpeed){
			this.rigid2d.AddForce(transform.right*key*this.walkForce);
			}

		if (key != 0) {
			transform.localScale = new Vector3 (key, 1, 1);
		} else {
			this.animator.speed = 1.0f;
		}

		if (this.rigid2d.velocity.y == 0) {
			this.animator.speed = speedx / 2.0f;
		}
		this.animator.speed = speedx / 2.0f;

		if(transform.position.y<-10){
			SceneManager.LoadScene("GameScene");
		}
	}
		
	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("골");
		SceneManager.LoadScene ("ClearScene");
	}

}