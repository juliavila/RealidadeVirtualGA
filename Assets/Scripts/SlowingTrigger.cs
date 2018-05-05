using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowingTrigger : MonoBehaviour {

	public const float spdMod = 1.5f;

	// Use this for initialization
	void Start () 
	{
		GetComponent<Renderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Toy") 
		{
			col.gameObject.GetComponent<ToyMove>().setSpeed(spdMod);
		}
	}
}
