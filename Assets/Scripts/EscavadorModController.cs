using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscavadorModController : MonoBehaviour {
	private Renderer rend;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Toy")
			col.gameObject.GetComponent<Renderer>().material.color = Color.yellow;

	}
}
