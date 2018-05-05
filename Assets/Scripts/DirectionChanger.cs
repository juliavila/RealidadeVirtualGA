using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionChanger : MonoBehaviour {

	public Vector3 dirMod;

	public Vector3 getDirectionModifier()
	{
		return dirMod;
	}

	public void setDirectionModifier(Vector3 dm)
	{
		dirMod = dm;
	}

	// Use this for initialization
	void Start () 
	{
		dirMod = new Vector3 (1, 0, 0);
		gameObject.tag = "DirectionSign";
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
