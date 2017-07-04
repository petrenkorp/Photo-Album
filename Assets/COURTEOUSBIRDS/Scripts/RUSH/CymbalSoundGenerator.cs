using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CymbalSoundGenerator : MonoBehaviour {

	public AudioSource sound1;
	public AudioSource sound2;
	public AudioSource sound3;
	private AudioSource[] soundArray;

	// Use this for initialization
	void Start () {
		soundArray = new AudioSource[3];
		soundArray[0] = sound1;
		soundArray[1] = sound2;
		soundArray[2] = sound3;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Play(){
		soundArray [Random.Range (0, soundArray.Length - 1)].Play ();	//play a random sound
	}
}
