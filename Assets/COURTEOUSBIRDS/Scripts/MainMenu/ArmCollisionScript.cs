using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmCollisionScript : MonoBehaviour {

    private Rigidbody2D arm;

	void Start () {
        arm = gameObject.GetComponent<Rigidbody2D>();
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        //arm.isKinematic = false;
        arm.freezeRotation = false;
        //velocity = projectile.velocity;
        //arm.velocity = velocity;
    }
}
