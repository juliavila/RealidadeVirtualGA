using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionChangerTrigger : MonoBehaviour {

	public Vector3 dirMod;

	// Use this for initialization
	void Start () 
	{
		dirMod =  transform.forward;
		transform.gameObject.tag = "DirectionSign";
	}

	// Update is called once per frame
	void Update () 
	{

	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Toy") 
		{
			col.gameObject.GetComponent<ToyMove>().setMoveDirection(dirMod);
		}
	}
}
