using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
	
	Rigidbody body;
	
	public bool gameOver = false;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
		if (gameOver) {
			
			if (Input.GetKey(KeyCode.Space)) {
				SceneManager.LoadScene("Game");
			}
			return;
		}
		if (Input.GetKey(KeyCode.Space)) {
			body.AddForce(new Vector3(0, 50,0), ForceMode.Acceleration);
		} else if (Input.GetKey(KeyCode.Space)) {
			body.velocity *= 0.15f;
		}
	}
	
	void OnTriggerEnter(Collider collider) {
		gameOver = true;
		body.isKinematic = true;
	}
}
