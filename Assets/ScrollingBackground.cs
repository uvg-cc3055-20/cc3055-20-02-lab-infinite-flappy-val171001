using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {

	public float scrolLingSpeed = 5f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// Move scene forward
		transform.Translate (Vector3.left * scrolLingSpeed * Time.deltaTime);

		// Infinite scene
		if (transform.position.x < -20.4f) {
			transform.position = new Vector3 (20.4f, transform.position.y, transform.position.z);
		}

	}

}
