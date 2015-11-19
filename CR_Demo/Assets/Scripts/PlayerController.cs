﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpHeight);
		}

		if (Input.GetKey(KeyCode.D)) 
		{
			rigidbody2D.velocity = new Vector2(moveSpeed, rigidbody2D.velocity.y);
		}

		if (Input.GetKey(KeyCode.A)) 
		{
			rigidbody2D.velocity = new Vector2(-moveSpeed, rigidbody2D.velocity.y);
		}




	
	}
}
