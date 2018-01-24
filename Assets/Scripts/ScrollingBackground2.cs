using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground2 : MonoBehaviour {

	public float scrolLingSpeed = 100f;

	// Use this for initialization
	void Start () {
		scrolLingSpeed = 5f;
	}

	// Update is called once per frame
	void Update () {
		// Move scene forward
		transform.Translate (Vector3.left * scrolLingSpeed * Time.deltaTime);

		// Infinite scene
		if (transform.position.x < -20f) {
			transform.position = new Vector3 (20f, transform.position.y, transform.position.z);
		}

	}


}
