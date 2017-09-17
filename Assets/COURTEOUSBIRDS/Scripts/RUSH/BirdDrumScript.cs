using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdDrumScript : MonoBehaviour {

	//private Rigidbody2D rb2d;
	public double drumHitCount = 0;	//how many drums have been hit so far

	public double pretentiousSoloLength = 15;	//number of drum hits at which to cut off (victory!)
	public ConcertSceneResetter reset;
	public DrumSoundGenerator skinSmasher;
	public CymbalSoundGenerator cymbalPlayer;
	public Canvas canvas;
	private bool stop = false;

	void Start () {
		PlayerStats.SetVictoryCanvas(canvas);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other) 
	{
		if (other.collider.CompareTag ("Drum")) {
			skinSmasher.smashThoseSkins ();	//play drums
			drumHitCount++;

		} else if (other.collider.CompareTag("Cymbal")) {
			cymbalPlayer.Play ();	//play cymbals
			drumHitCount += 0.5;	//cymbals don't count for as much as drums
		}

		if (drumHitCount > pretentiousSoloLength + 5 && !stop) {
			PlayerStats.LevelCompleted (3);
			stop = true;
		}

	}
}
