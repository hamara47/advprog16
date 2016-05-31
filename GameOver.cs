using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//Game over screen script

public class GameOver : MonoBehaviour {



	void Start ()
	{
		StartCoroutine("DoSomething");
	}


	IEnumerator DoSomething()
	{
		yield return new WaitForSeconds(5f);
		SceneManager.LoadScene ("Menu");
	}
}
