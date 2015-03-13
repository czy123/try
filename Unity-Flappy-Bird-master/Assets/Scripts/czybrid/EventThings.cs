using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

/// <summary>
/// add,publish,del eventthings
/// </summary>
public class EventThings 
{
	private static EventThings instance=null;
	public static EventThings Instance
	{
		get
		{
			if(instance==null)
				instance=new EventThings();
			return instance;
		}
	}
	protected Dictionary<string ,EventHandler> eventdict;
	public EventThings()
	{
		eventdict = new Dictionary<string, EventHandler> ();
	}

	public void ThingsPublish(string name)
	{
		this.ThingsPublish (name, null, EventArgs.Empty);
	}

	public void ThingsPublish(string name,object sender,EventArgs e)
	{
		if(eventdict[name]!=null)
		{
			eventdict [name] (sender, e);
		}
	}

	public void AddEvent(string name,EventHandler action)
	{
		if(!eventdict.ContainsKey(name))
		{
			eventdict.Add(name,action);
		}
		else
			eventdict [name]+= action;
	}
	public void DelEvent(string name,EventHandler action)
	{
		if(eventdict.ContainsKey(name))
		{
			eventdict[name]-=action;
		}
	}
}

public class EventChild:EventThings
{
	private static EventThings instance;
	public static EventThings Instance()
	{
		if(instance==null)
		{
			instance=new EventChild();
		}
		return instance;
	}
}