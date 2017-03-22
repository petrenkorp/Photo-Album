using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public static class PlayerStats {

	private static int[] scores;	//each index is a level's score (from 0-3)
	public static int currentLevel = -1;
	private static string[] levels;
	public static Canvas victoryCanvas;

	public static void Initialize() {
		//string sceneTemp;
		//int count = 0;

		currentLevel = 0;
		levels = new string[2];
		levels[0] = "concertScene";
		levels[1] = "curlingScene";
		scores = new int[levels.Length];
		//Debug.Log ("player stats initialize");

		/*
		  //dynamically grabs all level scenes and adds them - no good
		for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++) {
			SceneManager.LoadScene (i, LoadSceneMode.Additive);
			sceneTemp = SceneManager.GetSceneByBuildIndex (i).name;
			if (sceneTemp != "mainMenu" && sceneTemp != "Achievements" && sceneTemp != "Victory") {
				levels [count++] = SceneManager.GetSceneByBuildIndex (i).name;
				Debug.Log (levels [count - 1]);
			}
			SceneManager.UnloadSceneAsync(i);
		}
		*/

	}

	public static void LoadStats() {

		if (PlayerPrefs.HasKey ("currentLevel")) {
			currentLevel = PlayerPrefs.GetInt ("currentLevel");
			for (int x = 0; x < levels.Length; x++) {
				scores [x] = PlayerPrefs.GetInt (levels[x]);
			}
		} else {
			LoadBlankStats ();
		}
	}

	public static void LoadBlankStats () {
		PlayerPrefs.DeleteKey("currentLevel");
		currentLevel = 0;
		for (int x = 0; x < levels.Length; x++) {
			scores [x] = 0;
			PlayerPrefs.DeleteKey (levels[x]);
		}
	}

	public static void SetVictoryCanvas(Canvas canvas) {
		victoryCanvas = canvas;
	}

	public static void LevelCompleted (int score) {
		Component[] trophyScreens;
		string trophy;

		if (score == 3) {
			trophy = "GoldTrophy";
		} else if (score == 2) {
			trophy = "SilverTrophy";
		} else if (score == 1) {
			trophy = "BronzeTrophy";
		} else {
			trophy = "";
		}

		scores [currentLevel] = score;
		PlayerPrefs.SetInt (levels[currentLevel], score);

		if (score > 0) {

			trophyScreens = victoryCanvas.GetComponentsInChildren (typeof(Canvas), true);
			foreach (Canvas victoryScreen in trophyScreens) {
				if (victoryScreen.gameObject.tag == trophy) {
					victoryScreen.gameObject.SetActive (true);
				} else {
					victoryScreen.gameObject.SetActive (false);
				}
			}

			victoryCanvas.gameObject.SetActive (true);
			//printPlayerPrefs ();
		} else {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex, LoadSceneMode.Single);
		}

	}

	public static void NextLevel() {
		currentLevel++;
		PlayerPrefs.SetInt ("currentLevel", currentLevel);
		if (currentLevel >= levels.Length) {
			SceneManager.LoadScene ("Victory", LoadSceneMode.Single);
		} else {
			SceneManager.LoadScene (levels[currentLevel], LoadSceneMode.Single);
		}
	}

	public static string GetCurrentLevel(){
		return levels [currentLevel];
	}

	public static void printPlayerPrefs() {
		Debug.Log ("Current Level: " + currentLevel);
		for (var x = 0; x < levels.Length; x++) {
			Debug.Log (levels [x] + ": " + PlayerPrefs.GetInt (levels [x]) + "; " + scores[x]);
		}
	}
		
}
