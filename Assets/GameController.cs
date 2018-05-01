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

	// Use this for initialization
	void Start () {
		Debug.Log ("JULIA: ground name: " + ground.gameObject.name);
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
	}
	
	// Update is called once per frame
	void Update () {
		ground.GetComponent<Renderer>().enabled = isVisible;
		foreach (Transform child in ground.transform) {
			child.GetComponent<Renderer>().enabled = isVisible;
		}
	}

	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			Debug.Log("JULIA: Trackable " + mTrackableBehaviour.TrackableName + "/" + " found");
			OnTrackingFound();
		}
		else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
			newStatus == TrackableBehaviour.Status.NOT_FOUND)
		{
			Debug.Log("JULIA: Trackable " + mTrackableBehaviour.TrackableName + " lost");
			OnTrackingLost();
		}
		else OnTrackingLost();
	}

	private void OnTrackingFound()
	{
		if (mTrackableBehaviour.TrackableName == groundTrackableName)
			isVisible = true;

		Debug.Log (">>>>TAG<<<<");
		Debug.Log ("tag: " + mTrackableBehaviour.tag);

		//if (mTrackableBehaviour.tag == trackableTag)
			
	}

	private void OnTrackingLost()
	{
		if (mTrackableBehaviour.TrackableName == groundTrackableName)
			isVisible = false;
	}
		
}
