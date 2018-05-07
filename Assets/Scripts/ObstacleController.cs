using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {

		Debug.Log("~~~~TAG " + other.gameObject.tag);
		if (other.gameObject.tag == "Toy")
			Destroy(other.gameObject);
	}

}
