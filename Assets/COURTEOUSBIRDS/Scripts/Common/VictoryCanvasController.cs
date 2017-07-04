using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictoryCanvasController : MonoBehaviour {

	public Button nextLevel;
	public Button replayLevel;

	// Use this for initialization
	void Start () {
		nextLevel.onClick.AddListener (nextClick);
		replayLevel.onClick.AddListener (replayClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void replayClick() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex, LoadSceneMode.Single);
	}

	void nextClick(){
		PlayerStats.NextLevel ();
	}
}
