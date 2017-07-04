using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class VictoryController : MonoBehaviour {

	public Button mainMenuButton;

	// Use this for initialization
	void Start () {
		mainMenuButton.onClick.AddListener (MainMenuClick);
	}

	// Update is called once per frame
	void Update () {

	}

	void MainMenuClick() {
		SceneManager.LoadScene ("mainMenu", LoadSceneMode.Single);
	}
}
