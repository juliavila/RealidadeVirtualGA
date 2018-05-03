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
		Transform transformAux = transform;
		transformAux.position += new Vector3(0, 2, 0);
		GameObject newFixedMod = Instantiate(fixedModPrefab, transformAux.position, transformAux.rotation);
		emptyGameObj.transform.SetParent(ground.transform);
		newFixedMod.transform.SetParent(emptyGameObj.transform);
	}
}
