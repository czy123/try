using UnityEngine;
using System.Collections;
using System;

public class PipeMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Observers> ().AddEventthing ("GameOver", GameOver);
	}
	
	// Update is called once per frame
	void Update () 
	{
		rigidbody2D.velocity = new Vector2 (-1, 0);
		while (rigidbody2D.transform.position.x<-230)
		{
			Destroy(rigidbody2D.gameObject);
		}
	}

	void GameOver(object sender,EventArgs handl)
	{
		rigidbody2D.velocity = new Vector2 (0, 0);
	}
}
