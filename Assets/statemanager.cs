using UnityEngine;
using System.Collections;

public abstract class state
{
	public abstract void changeToMyState(train t);
}
	
public class backwardstate : state
{
	public override void changeToMyState(train t)
	{
		t.move = new backwardmovement();
		//backwardmovement.move (t);
	}
}

public class forwardstate : state
{
	public override void changeToMyState(train t)
	{
		t.move = new forwardmovement();
		//forwardmovement.move (t);
	}
}

public class stopstate : state
{
	public override void changeToMyState(train t)
	{
		t.move = new stopmovement();
		//stopmovement.move (t);
	}
}


public class statemanager : MonoBehaviour 
{
	state mystate;

	state holderforforwardstate = new forwardstate();
	state holderforbackwardstate = new backwardstate();
	state holderforstopstate = new stopstate();


	public train t;
	//void Start () {}

	//public train t = train.getInstance();

	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.D))
		{ 
			holderforbackwardstate.changeToMyState(t);
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			holderforforwardstate.changeToMyState(t);
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			holderforstopstate.changeToMyState(t);
		}
	}

}

/*
public class Globals
{
	public int _globalValue;

	public int Random
	{
		get {
			return _globalValue;
		}
		set{
			_globalValue = value;
		}
	}
}
*/