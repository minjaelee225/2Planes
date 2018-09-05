using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public int maxHealth = 1;
	protected int health;

	void Start() {
		health = maxHealth;
	}

	void Update() {
	
	}

	public virtual void takeDamage(int amount) {
		health -= amount;
		if (health <=0) {
			Destroy (gameObject);
		}
	}
}
