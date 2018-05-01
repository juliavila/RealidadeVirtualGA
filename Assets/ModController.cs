using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ModController : MonoBehaviour, ITrackableEventHandler {

	private TrackableBehaviour mTrackableBehaviour;

	//fixed mod
	public string trackableTag = "FixedMod";
	private bool showButtonApply = false;

	// Use this for initialization
	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
	}

	// Update is called once per frame
	void Update () {
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
		Debug.Log (">>>>TAG<<<< " + mTrackableBehaviour.tag);

		if (mTrackableBehaviour.tag == trackableTag) {
			showButtonApply = true;
		}

	}

	private void OnTrackingLost()
	{
		Debug.Log (">>>>TAG<<<< " + mTrackableBehaviour.tag);
	}
}
