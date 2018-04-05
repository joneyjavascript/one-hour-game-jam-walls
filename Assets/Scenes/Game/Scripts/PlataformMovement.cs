using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformMovement : MonoBehaviour {

    public float speed;
    public float maxVelocity;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Rigidbody2D body = GetComponent<Rigidbody2D>();
        body.AddForce(new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.fixedDeltaTime, 0, 0));
        float campledVelocityX = Mathf.Clamp(body.velocity.x, -maxVelocity, maxVelocity);
        body.velocity = new Vector2(campledVelocityX, body.velocity.y);
    }
}
