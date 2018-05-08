using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolin : MonoBehaviour {

	public float jumpStr = 7.5f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter(Collider col)
	{
		Debug.Log("&&& JUMP  colidiu com " + col.gameObject.tag);
		if (col.gameObject.tag == "Toy") 
		{
			Vector3 newMoveDir = 
				col.gameObject.GetComponent<ToyMove> ().getMoveDirection () + new Vector3 (0, jumpStr, 0);
			col.gameObject.GetComponent<ToyMove>().setMoveDirection(newMoveDir);
		}
	}
}
