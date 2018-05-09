using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsAction : MonoBehaviour {

	public void goToLevelSelector() {
		SceneManager.LoadScene("LevelSelector", LoadSceneMode.Single);
	}

	public void reestartLevel() {
		string nameScene = SceneManager.GetActiveScene ().name;
		SceneManager.LoadScene(nameScene, LoadSceneMode.Single);
	}

	public void openConfigs() {	}

	private void loadSingleScene(string nameScene) {
		SceneManager.LoadScene(nameScene, LoadSceneMode.Single);
	}
}
