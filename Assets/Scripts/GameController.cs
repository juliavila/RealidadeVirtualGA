﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class GameController : MonoBehaviour, ITrackableEventHandler{

	private TrackableBehaviour mTrackableBehaviour;

	// ground
	public GameObject ground;
	public string groundTrackableName = "ground";
	private bool isVisible = false;

	// end game
	public GameObject panelEndGame;
	public GameObject startingPoint;

	//fixed mod
	public string trackableTag = "FixedMod";

	private int numDead = 0;
	private int numSafe = 0;
	private int numTotal = 0;

	// Use this for initialization
	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
	}
	
	// Update is called once per frame
	void Update () {
		changeVisibility (ground.transform, isVisible);
		if (numTotal == startingPoint.GetComponent<StartingPoint>().totalToys)
			endGame ();
	}

	void changeVisibility (Transform parent, bool visibility){

		if (parent.GetComponent<Renderer>())
			parent.GetComponent<Renderer>().enabled = visibility;

		foreach (Transform child in parent) {
			changeVisibility (child, visibility);
		}

	}

	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
//			Debug.Log("JULIA: Trackable " + mTrackableBehaviour.TrackableName + "/" + " found");
			OnTrackingFound();
		}
		else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
			newStatus == TrackableBehaviour.Status.NOT_FOUND)
		{
//			Debug.Log("JULIA: Trackable " + mTrackableBehaviour.TrackableName + " lost");
			OnTrackingLost();
		}
		else OnTrackingLost();
	}

	private void OnTrackingFound()
	{
		if (mTrackableBehaviour.TrackableName == groundTrackableName)
			isVisible = true;			
	}

	private void OnTrackingLost()
	{
		if (mTrackableBehaviour.TrackableName == groundTrackableName)
			isVisible = false;
	}

	private void endGame() {
		panelEndGame.SetActive(true);
	}

	public void addDead() {
		numDead++;
	}
		
	public int getNumDead() {
		return numDead;
	}

	public void addSafe() {
		numSafe++;
	}

	public int getNumSafe() {
		return numSafe;
	}

	public void addNumTotal() {
		numTotal++;
	}

	public int getNumTotal() {
		return numTotal;
	}
}
