using UnityEngine;

public class ProjectileMainMenu : MonoBehaviour {

    public float xVelocity = 1;
    public float yVelocity = 1;

    private Vector2 launchVelocity;

    void Start () {

	}

    public void fire()
    {
        launchVelocity = new Vector2(xVelocity, yVelocity);
        GetComponent<Rigidbody2D>().isKinematic = false;
        GetComponent<Rigidbody2D>().velocity = launchVelocity;
    }
	


}
