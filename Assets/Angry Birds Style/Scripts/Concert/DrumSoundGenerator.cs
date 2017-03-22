using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumSoundGenerator : MonoBehaviour {

	public AudioSource sound1;
	public AudioSource sound2;
	public AudioSource sound3;
	public AudioSource sound4;
	public AudioSource sound5;
	public AudioSource sound6;
	public AudioSource sound7;

	private AudioSource[] soundArray;

	// Use this for initialization
	void Start () {
		soundArray = new AudioSource[7];
		soundArray[0] = sound1;
		soundArray[1] = sound2;
		soundArray[2] = sound3;
		soundArray[3] = sound4;
		soundArray[4] = sound5;
		soundArray[5] = sound6;
		soundArray[6] = sound7;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void smashThoseSkins(){
		soundArray [Random.Range (0, soundArray.Length - 1)].Play ();	//play a random sound
	}
}
