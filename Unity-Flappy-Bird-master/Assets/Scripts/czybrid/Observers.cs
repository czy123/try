using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Observers : MonoBehaviour {
	EventThings thingscontrol;
	Dictionary<string,EventHandler> eventdict;
	// Use this for initialization
	void Awake()
	{
		thingscontrol = EventThings.Instance;
		eventdict = new Dictionary<string, EventHandler> ();
	}

	void OnDestroy()
	{
		foreach(KeyValuePair<string, EventHandler> value in eventdict)
		{
			thingscontrol.DelEvent(value.Key,value.Value);
		}
	}

	public void AddEventthing(string name,EventHandler handle)
	{
		thingscontrol.AddEvent (name, handle);
		eventdict.Add (name, handle);
	}
}
