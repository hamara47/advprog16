using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//Delay script for stage start

public class WaitStage : MonoBehaviour {

	void Start ()
	{
		StartCoroutine("EnterStage");
	}


	IEnumerator EnterStage()
	{
		yield return new WaitForSeconds(15f);
		SceneManager.LoadScene ("Stage");

	}
}
