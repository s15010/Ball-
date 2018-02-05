using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameController2 : MonoBehaviour
{
	public  UnityEngine.UI.Text scoreLabel;
	public GameObject winnerLabelObject;

	public void Update ()
	{
		int count = GameObject.FindGameObjectsWithTag ("Item").Length;
		scoreLabel.text = count.ToString ();



//		if (count == 0) {
//			// クリア時の処理
//			// オブジェクトをアクティブにする
//			//			winnerLabelObject.SetActive (true);
//			SceneManager.LoadScene("stages");
//		}
	}
}