using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour 
{ // Initialize all the variables
	public GameObject player;
    private Vector3 offset;

	void Start () // Use this for initialization
	{
		offset = transform.position - player.transform.position;	
	}
	
	void LateUpdate () // Update is called once per frame
	{ // It is guaranteed to run after all the items have been processed in update
		transform.position = player.transform.position + offset;
	}
}
