using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public float speed = .1f;
    public float offsetZ = -10f;
    public GameObject target;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, target.transform.position + new Vector3(0,0, offsetZ), speed);

	}
}
