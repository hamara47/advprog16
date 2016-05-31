using UnityEngine;
using System.Collections;

//Fork controller script to hinder the fork movement speed with clicks

public class ForkController : MonoBehaviour {

	//Referencing Click script for values
	public Click click;
	public int divider = 50;





	// Update is called once per frame
	void Update () {
		
		float movespeed = 1.10f;
		float kek = click.klik;


		movespeed++;
		transform.position = new Vector3(transform.position.x + movespeed - (kek/divider), transform.position.y);



		
	}



}
