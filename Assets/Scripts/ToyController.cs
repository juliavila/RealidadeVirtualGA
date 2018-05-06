using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ToyController : MonoBehaviour {

	private float speed = 0.05F;
	private Transform target;
	// Use this for initialization
	void Start () 
	{
		target = GameObject.Find("CubeB").transform;
	}

	// Update is called once per frame
	void FixedUpdate () 
		{
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target.position, speed);
	}
		
	public void OnCollisionEnter(Collision col)
	{
//		Debug.Log("Colision " + col.gameObject.name);
		if (col.gameObject.name == "CubeB")
			Destroy (gameObject);
	}
}
