using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ConcertSceneResetter : MonoBehaviour {

	public Rigidbody2D projectile;			//	The rigidbody of the projectile
	public float resetSpeed = 0.4f;		//	The angular velocity threshold of the projectile, below which our game will reset
	public BirdDrumScript player;
	public int bronze = 5;
	public int silver = 10;
	public int gold = 15;

	private float resetSpeedSqr;			//	The square value of Reset Speed, for efficient calculation
	private SpringJoint2D spring;			//	The SpringJoint2D component which is destroyed when the projectile is launched

	void Start ()
	{
		if (PlayerStats.currentLevel == -1) {
			PlayerStats.Initialize ();
		}
		//	Calculate the Resset Speed Squared from the Reset Speed
		resetSpeedSqr = resetSpeed * resetSpeed;

		//	Get the SpringJoint2D component through our reference to the GameObject's Rigidbody
		spring = projectile.GetComponent <SpringJoint2D>();
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			Reset ();
		}

		if (spring == null && projectile.velocity.sqrMagnitude < resetSpeedSqr) {
			Reset ();
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		if (other.GetComponent<Rigidbody2D>() == projectile) {
			Reset ();
		}
	}

	public void Reset () {
		if (player.drumHitCount > gold) {
			PlayerStats.LevelCompleted (3);
		} else if (player.drumHitCount > silver) {
			PlayerStats.LevelCompleted (2);
		} else if (player.drumHitCount > bronze) {
			PlayerStats.LevelCompleted (1);
		} else {
			PlayerStats.LevelCompleted (0);
		}
	}
}
