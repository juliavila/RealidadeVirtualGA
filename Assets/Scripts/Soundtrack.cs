using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Soundtrack : MonoBehaviour {

	public Text txtMusic;

	private static bool created = false;
	void Awake()
	{
		if (!created)
		{
			DontDestroyOnLoad(this.gameObject);
			created = true;
			Debug.Log("Awake: " + this.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void mute() {
		bool isMute = !GetComponent<AudioSource> ().mute;
		GetComponent<AudioSource> ().mute = isMute;
		txtMusic.text = isMute ? "j" : "ç";
	}

}
