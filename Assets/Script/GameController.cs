using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameController : MonoBehaviour{

	public Text scoreLabel;
	public GameObject winnerLabelObject;

	public void Time() {
		SceneManager.LoadScene ("stages");

	}

	public void Update (){
		
		int count = GameObject.FindGameObjectsWithTag ("Capsule").Length;
		scoreLabel.text = count.ToString ();
		if (count == 0) {
			Debug.Log ("A");
			winnerLabelObject.SetActive (true);
			Invoke ("Time", 3);
					
		}

	}
}