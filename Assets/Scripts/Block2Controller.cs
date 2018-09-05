using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block2Controller : MonoBehaviour {

	public GameObject enemy;

	void Start () {
		StartCoroutine ("spawn");
	}

	void Update () {

	}

	private void spawnBlock() {
		int rando;
		Vector3 newPos;

		rando = Random.Range (0, 2);
		if (rando == 0) {
			newPos = new Vector3 (8, 13, 0);
		} else {
			newPos = new Vector3 (3, 13, 0);
		}
		Instantiate (enemy, newPos, Quaternion.identity);
	}

	IEnumerator spawn() {
		int t = Random.Range (1, 3);
		yield return new WaitForSeconds (t);
		spawnBlock ();
		StartCoroutine ("spawn");
	}
}
