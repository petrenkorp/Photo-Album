using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MainMenuScript : MonoBehaviour {

	public Button continueButton;
	public Button newGameButton;
	public Button achievementsButton;
	public Button buyButton;

	// Use this for initialization
	void Start () {
		PlayerStats.Initialize ();
		continueButton.onClick.AddListener (ContinueClick);
		newGameButton.onClick.AddListener (NewGameClick);
		achievementsButton.onClick.AddListener (AchievementsClick);
		buyButton.onClick.AddListener (BuyClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ContinueClick() {
		PlayerStats.LoadStats ();
		SceneManager.LoadScene(PlayerStats.GetCurrentLevel(), LoadSceneMode.Single);
	}

	void NewGameClick() {
		PlayerStats.LoadBlankStats ();
		//PlayerStats.printPlayerPrefs ();
		SceneManager.LoadScene(PlayerStats.GetCurrentLevel(), LoadSceneMode.Single);
	}

	void AchievementsClick() {
		//load achievements scene
		SceneManager.LoadScene ("Achievements", LoadSceneMode.Single);
	}

	void BuyClick() {
		//open browser handler for URL
		Debug.Log ("buy");
	}
}
