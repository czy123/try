using UnityEngine;
using System.IO;
using System.Collections;
using LitJson;

public class DieOver : MonoBehaviour {

	public GameObject  pipe;
	// Use this for initialization
	void Start () 
	{
		Debug.Log (pipe.name);
		StartCoroutine (AddPipe ());
		EventThings.Instance.AddEvent ("gameover", Godie);
//		InvokeRepeating (AddPipe, 2, 3);
	}

	IEnumerator  AddPipe()
	{
		float y = Random.Range (-100, 100);
		Vector3 pos = new Vector3 (0, y,0);
		yield return new WaitForSeconds (1f);
		Debug.Log (pos);
		GameObject gameobj = Instantiate (pipe) as GameObject;
		gameobj.transform.position = new Vector3 (300, y, 0);
//		gameobj.transform.parent = transform;
//		gameobj.transform.localPosition=pos;
//		gameobj.transform.localScale = new Vector3 (1, 1, 1);
//		gameobj.transform.Translate (new Vector3 (2, 0, 0));
//		gameobj.velocity = new Vector2 (-2f, 0);
		StartCoroutine (AddPipe());

//		     while (gameobj.transform.position.x<-230)
//		{
//			Destroy(gameobj.gameObject);
//		}
	}

	public void Godie(object sender,System.EventArgs e)
	{
		StopAllCoroutines ();
	}
}
