using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// ★追加（ポイント）
using UnityEngine.AI;

public class Chase : MonoBehaviour {

	public GameObject target;
	private NavMeshAgent agent;

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

	void Start () {
		agent = GetComponent<NavMeshAgent>();
	}

	void Update () {

		// 敵の目的地にターゲットの位置を設定する。
		agent.destination = target.transform.position;
	}
}