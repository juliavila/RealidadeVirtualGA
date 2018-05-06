using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
// 		Debug.Log ("JULIA debug do SceneSelector ");
		
	}

	public void goToScene(string nameScene) {
		SceneManager.LoadScene(nameScene, LoadSceneMode.Single);
	}
}
