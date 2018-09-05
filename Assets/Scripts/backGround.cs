using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backGround : MonoBehaviour {

	public GameObject BackGround;

	void Start () {
		StartCoroutine ("spawn");
	}
		
	void Update () {

	}

	private void createScene() {
		Vector3 newPos = new Vector3 (0, 23, 0); 
		Instantiate (BackGround, newPos, Quaternion.identity);
	}

	IEnumerator spawn() {
		createScene ();
		yield return new WaitForSeconds (6);
		StartCoroutine ("spawn");
	}

}
