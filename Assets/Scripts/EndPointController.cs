using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndPointController : MonoBehaviour {

	public Text txtNumSafe;
	public GameObject gameController;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {

		gameController.GetComponent<GameController>().addSafe();
		txtNumSafe.text = gameController.GetComponent<GameController>().getNumSafe().ToString();

		if (other.gameObject.tag == "Toy")
			Destroy(other.gameObject);
	}
}
