using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingPoint : MonoBehaviour {

	public GameObject toyPrefab;
	public GameObject ground;
	public float spawnTime = 1f; 
	public int totalToys = 5;
	private int contToys = 0;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	// Update is called once per frame
	void Update () {

	}

	public void Spawn()
	{
		if (contToys >= totalToys)
			return;
		
		contToys++;
		GameObject emptyGameObj = new GameObject();

		GameObject toy = Instantiate(toyPrefab, transform.position, emptyGameObj.transform.rotation);
		emptyGameObj.transform.SetParent(ground.transform);
		toy.transform.SetParent(emptyGameObj.transform);

	}
}
