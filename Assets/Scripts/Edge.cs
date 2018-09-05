using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collision) {
		Health otherHealth = collision.gameObject.GetComponent<Health> ();
		if (collision.gameObject.tag == "Enemy") {
			otherHealth.takeDamage (1);
		}
	}

	void Update() {
		Vector3 pos = Camera.main.WorldToViewportPoint (transform.position);
		pos.x = Mathf.Clamp01 (pos.x);
		pos.y = Mathf.Clamp01 (pos.y);
		transform.position = Camera.main.ViewportToWorldPoint (pos);
	}
}
