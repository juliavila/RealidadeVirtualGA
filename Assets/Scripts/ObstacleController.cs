using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleController : MonoBehaviour {

	public Text txtNumDead;
	public GameObject gameController;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		
		gameController.GetComponent<GameController>().addDead();
		txtNumDead.text = gameController.GetComponent<GameController>().getNumDead().ToString();
			
		if (other.gameObject.tag == "Toy")
			Destroy(other.gameObject);
	}

}
