using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


//Script to trigger death upon touching lava

public class Burned : MonoBehaviour {



	void OnTriggerEnter2D(Collider2D col){

		if (col.CompareTag ("Player")) {
			Debug.Log ("BTFO");

			Die ();
		}

	}

	void Die() {
		Destroy(gameObject);
		SceneManager.LoadScene ("Over");



		
	}


	


}

