using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


//Script to detect fork reaching safe zone to win the game

public class WinCondition : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D col){

		if (col.CompareTag ("Fork")) {
			Debug.Log ("Winrar");
			SceneManager.LoadScene ("Win");
		}

	}




}