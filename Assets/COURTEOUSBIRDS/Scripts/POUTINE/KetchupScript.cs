using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KetchupScript : MonoBehaviour {

	//public Sprite ketchup1;	//don't need; assigned by default
	public Sprite ketchup2;
	public Sprite ketchup3;
	public Sprite ketchup4;
	public Sprite ketchup5;
	public Sprite ketchupSplat;
	public int delay = 2;
	private SpriteRenderer selfSprite;
	private Collider2D bounds;

	// Use this for initialization
	void Start () {
		selfSprite = GetComponent<SpriteRenderer>();
		bounds = GetComponent<Collider2D>();
		StartCoroutine(ketchupTimer());		
	}

	IEnumerator ketchupTimer() {
		yield return new WaitForSecondsRealtime(delay);
		selfSprite.sprite = ketchup2;
		yield return new WaitForSecondsRealtime(delay);
		selfSprite.sprite = ketchup3;
		yield return new WaitForSecondsRealtime(delay);
		selfSprite.sprite = ketchup4;
		yield return new WaitForSecondsRealtime(delay);
		selfSprite.sprite = ketchup5;
		yield return new WaitForSecondsRealtime(delay);
		GetComponent<Rigidbody2D>().isKinematic = false;
	}
	
	void OnCollisionEnter2D(Collision2D other) {
		if (other.collider.tag == "Damager") {	//the bird

		} else if (other.collider.tag == "Poutine") {	//poutine
			selfSprite.sprite = ketchupSplat;
		}
	}
}
