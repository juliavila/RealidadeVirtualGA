using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingPoint : MonoBehaviour {

	public GameObject toyPrefab;
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
		/* if (contToys >= totalToys)
			return; */
		contToys++;
		GameObject anchorImageTarget = GameObject.Find("BaseImageTarget");
		GameObject toy = Instantiate(toyPrefab, transform.position, transform.rotation);
		toy.transform.parent = anchorImageTarget.transform;
	}
}
