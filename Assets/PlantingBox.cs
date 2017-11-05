using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantingBox : MonoBehaviour {

    public Rigidbody2D Tree;
    public SpriteRenderer TreeSprite;
    public Sprite Sapling2;
    

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void OnCollisionEnter2D (Collision2D other) {
        Debug.Log(other.collider.tag);
		if (other.collider.tag == "Sapling") {
            
            Tree.isKinematic = true;
            TreeSprite.sprite = Sapling2;
        }
	}
}
