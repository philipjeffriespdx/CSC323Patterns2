using UnityEngine;
using System.Collections;

public abstract class movement
{
	//public abstract void move(Transform t);
	public abstract void move(ref float x);

}
	
public class backwardmovement : movement
{
	public override void move(ref float x)
	{
		x = -1.0f;
	}
}
	
public class forwardmovement :movement 
{
	public override void move(ref float x)
	{
		/*
		public override void move(Transform t)
		{
			t.position = t.position + t.forward * .01f;
		}
		*/
		x = 1.0f;
	}
}
	
public class stopmovement : movement
{
	public override void move(ref float x)
	{
		x = 0.0f;
	}
}

public class train : MonoBehaviour
{
	public float thrust;
	public Rigidbody rb;
	public movement move = new stopmovement();
	public float randomizer = 1.0f;
	//public float rand = 1;

	//create an instance of train
	public static train instance = new train ();

	//make the constructor private so that the class cannot be instantiated
	private train() {}

	public static train getInstance()
	{
		return instance;
	}
	/*
	public static void setRandom ()
	{
		rand = Random.Range (1.0f, 9.0f);
	}
	*/
	void Start() 
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate() 
	{
		move.move(ref thrust);
		//rb.velocity = transform.forward * thrust;
		rb.AddForce(transform.forward * thrust * 20);

	}
		
	// Update is called once per frame
	/*
	void Update () 
	{
		move.move(transform);
	}
	*/
}