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
	private bool hasCollided = false;

	// Use this for initialization
	void Start () {
		selfSprite = GetComponent<SpriteRenderer>();
		bounds = GetComponent<Collider2D>();
		Debug.Log(bounds.bounds.extents);
		StartCoroutine(ketchupTimer());		
	}

	IEnumerator ketchupTimer() {
		yield return new WaitForSecondsRealtime(delay);
		if (!hasCollided) {
			selfSprite.sprite = ketchup2;
			bounds.bounds.Expand(2);	//doesn't work - why?
			Debug.Log(bounds.bounds.extents);
		}
		
		yield return new WaitForSecondsRealtime(delay);
		if (!hasCollided) {
			selfSprite.sprite = ketchup3;
			bounds.bounds.Expand(2);
			Debug.Log(bounds.bounds.extents);
		}
		yield return new WaitForSecondsRealtime(delay);
		if (!hasCollided) {
			selfSprite.sprite = ketchup4;
			bounds.bounds.Expand(2);
			Debug.Log(bounds.bounds.extents);
		}
		yield return new WaitForSecondsRealtime(delay);
		if (!hasCollided) {
			selfSprite.sprite = ketchup5;
			bounds.bounds.Expand(2);
			Debug.Log(bounds.bounds.extents);
		}

		yield return new WaitForSecondsRealtime(delay);
		if (!hasCollided) {
			GetComponent<Rigidbody2D>().isKinematic = false;
		}
	}
	
	void OnCollisionEnter2D(Collision2D other) {
		selfSprite.sprite = ketchupSplat;
		if (other.collider.tag == "Damager") {	//the bird
			Debug.Log("hithithit");
			//selfSprite.sprite = ketchupSplat;
			//GetComponent<Rigidbody2D>().isKinematic = false;
			hasCollided = true;
		} else if (other.collider.tag == "Poutine") {	//poutine
			//selfSprite.sprite = ketchupSplat;
		}
	}
}
