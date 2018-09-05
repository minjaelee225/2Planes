using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour {
	float speed = 250;
	Health playerHealth;

	// Use this for initialization
	void Start () {
		playerHealth = GetComponent<Health> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow) && transform.position.x == 3) {
			transform.SetPositionAndRotation (new Vector3 (8, -6, 0), Quaternion.identity);
		}
		if (Input.GetKey (KeyCode.LeftArrow) && transform.position.x == 8) {
			transform.SetPositionAndRotation (new Vector3 (3, -6, 0), Quaternion.identity);
		}
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Enemy") {
			playerHealth.takeDamage (1);
		}
	}


}
