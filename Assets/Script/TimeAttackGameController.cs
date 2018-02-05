using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TimeAttackGameController : MonoBehaviour{

	public Text scoreLabel;
	public GameObject winnerLabelObject;
	//	public GameObject StageSelect;

	public void Time() {
		SceneManager.LoadScene ("TimeAttackstages");

	}

	public void Update (){

		int count = GameObject.FindGameObjectsWithTag ("Capsule").Length;
		scoreLabel.text = count.ToString ();
		if (count == 0) {
			
			winnerLabelObject.SetActive (true);
			Invoke ("Time", 3);
			//			StageSelect.SetActive (true);

		}

	}
}