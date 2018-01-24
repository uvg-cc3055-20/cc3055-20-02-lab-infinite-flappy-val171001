﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour {

	private float scrollingSpeed = 5f;

	void Start () {
		scrollingSpeed = 5f;
	}

	void Update () {
		transform.Translate(Vector3.left * scrollingSpeed * Time.deltaTime);
		if (transform.position.x < -10)
		{
			Destroy(gameObject);
		}
	}
}
