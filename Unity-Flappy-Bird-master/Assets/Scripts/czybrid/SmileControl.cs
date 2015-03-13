using UnityEngine;
using System.Collections;

public class SmileControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			transform.rigidbody2D.velocity=new Vector2(0,2);
		}
	
	}
	void OnTriggerExit2D(Collider2D col)
	{
		EventThings.Instance.ThingsPublish ("Addscore");
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		rigidbody2D.velocity = new Vector2 (0, 0);
		EventThings.Instance.ThingsPublish ("gameover");
		GetComponent<UISprite> ().spriteName = "Emoticon - Dead";
		this.enabled = false;
	}
	
}
