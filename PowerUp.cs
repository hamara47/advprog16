using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


//Trigger event for boosted performance

public class PowerUp : MonoBehaviour {


	public int PowerIncrease = 0;

	void OnTriggerEnter2D() {
		Debug.Log ("PowerUp");
		PowerIncrease = 50;
		Destroy(gameObject);

		SceneManager.LoadScene ("Forkmap2");




	}
}
