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

    // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController>();
        myRigidBody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        myRigidBody.velocity = new Vector2(speed, myRigidBody.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, vertVelocity);
        }
    }
}
