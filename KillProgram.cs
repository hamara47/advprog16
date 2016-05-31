using UnityEngine;
using System.Collections;

//Script to end the program

public class KillProgram : MonoBehaviour {

		void Update ()
		{
			StartCoroutine("KillThis");
		}


		IEnumerator KillThis()
		{
			yield return new WaitForSeconds(8f);
			Application.Quit ();
		}
	}