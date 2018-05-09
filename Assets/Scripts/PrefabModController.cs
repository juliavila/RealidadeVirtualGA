using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabModController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col)
	{
		Debug.Log ("@#$% NAME " + col.gameObject.name);
		if (col.gameObject.name != "Ground") {
			Physics.IgnoreCollision (col.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
		}

	}
}
