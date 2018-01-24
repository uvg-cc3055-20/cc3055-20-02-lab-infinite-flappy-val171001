using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

    public float jumpForce = 200f;
    private Rigidbody2D rb;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
		rb.freezeRotation = true;
	}
	
	void Update () {
        if (Input.GetButtonDown("Jump")) {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce);
        }
	}

	private void OnTriggerEnter2D(Collider2D collision){
		if (collision.tag == "death") {
			GameController.instance.gameOver = true;
		} else {
			GameController.instance.score++;
			Debug.Log (GameController.instance.score);
		}
			

	}
}
