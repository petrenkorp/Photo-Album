using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuBGClick : MonoBehaviour {

    public ProjectileMainMenu projectile;
    private Collider2D clickable;

    // Use this for initialization
 
	void Start () {
        clickable = gameObject.GetComponent<Collider2D>();
	}


    void OnMouseDown()
    {
        projectile.fire();
    }
}
