using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour {

	GameObject hpGage;
	// Use this for initialization
	void Start () {
		this.hpGage = GameObject.Find ("hpGage");
	}

	public void DecreaseHP(){
		this.hpGage.GetComponent<Image> ().fillAmount -= 0.1f;
	}
	// Update is called once per frame

	public void IncreaseHP(){
		this.hpGage.GetComponent<Image> ().fillAmount += 0.1f;
	}

	public void upHP(){
		this.hpGage.GetComponent<Image> ().fillAmount += 0.003f;
	}

	public void slowHP(){
		this.hpGage.GetComponent<Image> ().fillAmount -= 0.003f;
	}

	void Update () {
		if(hpGage.GetComponent<Image>().fillAmount==0)
			SceneManager.LoadScene ("GameOverScene");
			
	}
} 
