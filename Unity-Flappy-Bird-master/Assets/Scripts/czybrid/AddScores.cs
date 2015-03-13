using UnityEngine;
using System.Collections;
using System;

public class AddScores : MonoBehaviour {

	public UILabel score;
	// Use this for initialization
	void Start () 
	{
		EventThings.Instance.AddEvent ("Addscore", AddScore);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddScore(object sender,EventArgs e)
	{
		score.text = (int.Parse (score.text) + 1).ToString ();
	}
}
