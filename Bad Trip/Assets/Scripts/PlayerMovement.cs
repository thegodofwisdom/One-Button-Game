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
    private CircleCollider2D playerCollider;
    public float tapGap = .5f;
    private float lastTap = 0;

    public bool grounded;
    public LayerMask isGround;

    // Use this for initialization
    void Start () {
        lastTap = 0;
        controller = GetComponent<CharacterController>();
        myRigidBody = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<CircleCollider2D>();
    }
	
	// Update is called once per frame
	void Update () {
        grounded = Physics2D.IsTouchingLayers(playerCollider, isGround);

        myRigidBody.velocity = new Vector2(speed, myRigidBody.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, vertVelocity);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if((Time.time - lastTap) < tapGap)
            {
                Debug.Log("double");
                if (playerCollider.enabled)
                {
                    playerCollider.enabled = !playerCollider.enabled;
                }
                else
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>().enabled = true;
                }
                if(myRigidBody.gravityScale != 0)
                {
                    myRigidBody.gravityScale = 0;
                }
                else
                {
                    myRigidBody.gravityScale = 1;
                }
                myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, 0);
            }
            lastTap = Time.time;
        }
        
    }
    
}
