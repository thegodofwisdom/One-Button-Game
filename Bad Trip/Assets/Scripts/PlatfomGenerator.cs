using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatfomGenerator : MonoBehaviour {
    public GameObject platform;
    public GameObject wall;
    public GameObject smallWall;
    public Transform genPoint;
    public float gap;

    private float platfomrLength;
	// Use this for initialization
	void Start () {
        platfomrLength = platform.GetComponent<BoxCollider2D>().size.x;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < genPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + platfomrLength + gap, transform.position.y, transform.position.z);
            Instantiate(platform, transform.position, transform.rotation);
            Instantiate(wall, transform.position, Quaternion.Euler(0,0,90));
        }
	}
}
