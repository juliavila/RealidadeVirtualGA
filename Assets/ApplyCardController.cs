using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyCardController : MonoBehaviour {

	public GameObject ground;
	public GameObject fixedModPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void applyFixedMod() {
		GameObject emptyGameObj = new GameObject();
		GameObject newFixedMod = Instantiate(fixedModPrefab, transform.position, transform.rotation);
		emptyGameObj.transform.SetParent(ground.transform);
		newFixedMod.transform.SetParent(emptyGameObj.transform);
	}
}
