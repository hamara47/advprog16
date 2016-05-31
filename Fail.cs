using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//Script for death upon fork failure

public class Fail : MonoBehaviour {

	public int health = 2;

	void OnTriggerEnter2D(Collider2D col) {
		if (col.CompareTag ("Socket")) {
			
			Debug.Log ("BTFO");

			health--;
		}

		if (col.CompareTag ("Goal")) {

			SceneManager.LoadScene ("Win");

		}
	
	}

	void Update() {
		if (health == 1) {
			Die();

		}
	}

	void Die() {
		Destroy(gameObject);
		SceneManager.LoadScene ("Over");
		health--;

	}


}

