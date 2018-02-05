using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RotateCube : MonoBehaviour
{
//	public Vector3 angle;


	// オブジェクトと接触した時に呼ばれるコールバック
	void OnCollisionEnter (Collision hit)
	{

		int count = GameObject.FindGameObjectsWithTag ("Capsule").Length;


		// 接触したオブジェクトのタグが"Player"の場合
		if (count > 0) {
			if (hit.gameObject.CompareTag ("Player")) {

				// 現在のシーン番号を取得
				int sceneIndex = SceneManager.GetActiveScene ().buildIndex;

				// 現在のシーンを再読込する
				SceneManager.LoadScene (sceneIndex);
			}
		}

	}
	void Update () {
//		transform.Rotate (angle * Time.deltaTime);
		transform.rotation *= Quaternion.AngleAxis (1, Vector3.up);
	}
}