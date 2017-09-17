using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceHitDetector : MonoBehaviour {

	private Vector2 vel;
	public Rigidbody2D rock;
	public float drag = 1;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D collision) {

		//if (!this.activeSelf) return;

		if (collision.name.IndexOf("Projectile") >= 0) {
			if (rock.GetComponent<RockMove>().hasFired == false) {
				this.gameObject.SetActive(false);
			}
		} else if (collision.name == "CurlingRock") {
			rock.GetComponent<Rigidbody2D>().drag += drag;
			Debug.Log(rock.GetComponent<Rigidbody2D>().drag);
			return;
		}

	}
}
