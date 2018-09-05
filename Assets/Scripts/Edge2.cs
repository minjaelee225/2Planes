using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge2 : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collision) {
		Health otherHealth = collision.gameObject.GetComponent<Health> ();
		if (collision.gameObject.tag == "Enemy") {
			otherHealth.takeDamage (1);
		}
	}

	void Update() {

	}
}
