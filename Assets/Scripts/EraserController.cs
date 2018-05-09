using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraserController : MonoBehaviour {

	public GameObject buttonErase;
	private GameObject mod;

	// Use this for initialization
	void Start () {
		buttonErase.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Mod") {
			mod = col.gameObject;
			col.gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
			buttonErase.SetActive (true);
		}
	}

	public void erase() {
		Destroy (mod);
	}
		
}
