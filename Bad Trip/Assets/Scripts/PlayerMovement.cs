using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private CharacterController controller;
    private Vector2 moveVector;
    private Rigidbody2D myRigidBody;
    public float speed = 2.0f;
    private float vertVelocity = 5.0f;
    private float gravity = 12.0f;
    private Collider2D playerCollider;

    public bool grounded;
    public LayerMask isGround;

    // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController>();
        myRigidBody = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<Collider2D>();
    }
	
	// Update is called once per frame
	void Update () {
        grounded = Physics2D.IsTouchingLayers(playerCollider, isGround);

        myRigidBody.velocity = new Vector2(speed, myRigidBody.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, vertVelocity);
        }
    }
}
