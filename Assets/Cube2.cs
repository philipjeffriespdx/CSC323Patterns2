using UnityEngine;
using System.Collections;

public class Cube2 : MonoBehaviour {
	public train t;

	public state mystate;

	public state holderforforwardstate = new forwardstate();
	public state holderforbackwardstate = new backwardstate();
	public state holderforstopstate = new stopstate();

	void OnMouseDown()
	{
		//Destroy (t.gameObject);
		//if (t.random == 1) {
			//holderforforwardstate.changeToMyState (t);
		//}
		if (t.randomizer < 2.0f)
			holderforforwardstate.changeToMyState (t);
		else if (t.randomizer >= 2.0f && t.randomizer < 3.0f)
			holderforstopstate.changeToMyState (t);
		else if (t.randomizer >= 3.0f && t.randomizer < 4.0f)
			holderforbackwardstate.changeToMyState (t);
		else if (t.randomizer >= 4.0f && t.randomizer < 5.0f)
			holderforstopstate.changeToMyState (t);
		else if (t.randomizer >= 5.0f && t.randomizer < 6.0f)
			holderforforwardstate.changeToMyState (t);
		else if (t.randomizer >= 6.0f && t.randomizer < 7.0f)
			holderforbackwardstate.changeToMyState (t);
	}
}
