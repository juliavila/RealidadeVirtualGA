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
		dirMod =  transform.forward;
		transform.gameObject.tag = "DirectionSign";
	}

	// Update is called once per frame
	void Update () 
	{

	}
}
