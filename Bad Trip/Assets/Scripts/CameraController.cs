using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    private Transform lookAt;
    private Vector3 offset;
    // Use this for initialization
    void Start () {
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - lookAt.position;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x, 0, -7.5f) + offset;
    }
}
