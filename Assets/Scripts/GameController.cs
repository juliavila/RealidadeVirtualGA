using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class GameController : MonoBehaviour, ITrackableEventHandler{

	private TrackableBehaviour mTrackableBehaviour;

	// ground
	public GameObject ground;
	public string groundTrackableName = "ground";
	private bool isVisible = false;

	//fixed mod
	public string trackableTag = "FixedMod";

	private int numDead = 0;
	private int numSafe = 0;

	// Use this for initialization
	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
	}
	
	// Update is called once per frame
	void Update () {
		changeVisibility (ground.transform, isVisible);
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

//		Debug.Log (">>>>TAG<<<<");
//		Debug.Log ("tag: " + mTrackableBehaviour.tag);

		//if (mTrackableBehaviour.tag == trackableTag)
			
	}

	private void OnTrackingLost()
	{
		if (mTrackableBehaviour.TrackableName == groundTrackableName)
			isVisible = false;
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
}
