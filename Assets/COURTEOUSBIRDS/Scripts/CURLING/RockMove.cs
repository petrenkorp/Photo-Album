﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMove : MonoBehaviour {

    //public Rigidbody2D projectile;          //	The rigidbody of the projectile
    //public float resetSpeed = 0.025f;       //	The angular velocity threshold of the projectile, below which our game will reset

    public Rigidbody2D curlingRock;
    public float rockSpeed;
    public bool hasFired = false;

    //private float resetSpeedSqr;            //	The square value of Reset Speed, for efficient calculation
    //private SpringJoint2D spring;           //	The SpringJoint2D component which is destroyed when the projectile is launched

    void Start () {
		
	}
	
	
	void Update () {

    }

    public void RockMovement() {

        curlingRock.velocity = new Vector2(rockSpeed,0); 
        hasFired = true;

    }

    public bool hasStopped(){
        return curlingRock.velocity.x <= 0.1;
    }

}
