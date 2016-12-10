using UnityEngine;
using System.Collections;

public class RatScript : MonoBehaviour {

	public float moveSpeed;

	public Animator rottaAnim;

	void Start() {

	}


	void Update() {


		if (Input.GetKey(KeyCode.W)) {
			transform.Translate(Vector2.up * moveSpeed);
			rottaAnim.SetBool("move", true);
		}
		if (Input.GetKey(KeyCode.S)) {
			transform.Translate(Vector2.down * moveSpeed);
			rottaAnim.SetBool("move", true);
		}
		if (Input.GetKey(KeyCode.D)) {
			transform.Translate(Vector2.right * moveSpeed);
			rottaAnim.SetBool("move", true);
		}
		if (Input.GetKey(KeyCode.A)) {
			transform.Translate(Vector2.left * moveSpeed);
			rottaAnim.SetBool("move", true);
		}
		else {
			rottaAnim.SetBool("move", false);
		}
	}
}