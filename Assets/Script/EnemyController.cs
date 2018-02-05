using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour{

	public Text scoreLabel;
	public GameObject winnerLabelObject;

	public void Time() {
		SceneManager.LoadScene ("Enemystages");

	}

	public void Update (){

		int count = GameObject.FindGameObjectsWithTag ("Capsule").Length;
		scoreLabel.text = count.ToString ();
		if (count == 0) {
			winnerLabelObject.SetActive (true);
			Invoke ("Time", 3);

		}

	}
}

