using UnityEngine;
using System.Collections;

public class ButtonRandom : MonoBehaviour {
	public train t;
	//public Globals g;


	void OnMouseDown()
	{
		t.randomizer = Random.Range(1.0f,7.0f);
	}
}
