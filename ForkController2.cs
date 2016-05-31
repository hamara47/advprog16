using UnityEngine;
using System.Collections;

//Script of controlling the fork of the second map

public class ForkController2 : MonoBehaviour {

	//Referencing Click script for values
	public Click click;
	public int divider = 14;





	// Update is called once per frame
	void Update () {
		
		float movespeed = 0.10f;
		float kek = click.klik;


		movespeed++;
		transform.position = new Vector3(transform.position.x + movespeed - (kek/divider), transform.position.y);



		
	}



}
