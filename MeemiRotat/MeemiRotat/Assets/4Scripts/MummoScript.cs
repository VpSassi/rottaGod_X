using UnityEngine;
using System.Collections;

public class MummoScript : MonoBehaviour {

	public float scanSpeed;
	public float alertSpeed;

	float shotgunReloadTimer;
	public float shotgunReloadTotTimer;

	float aimTimer;
	public float aimTotTimer;

	public bool isOnSight;
	public int playerCount;

	public Transform[] wPs;
	int nextWp;
	float closeEnuf = 0.5f;

	void Start () {
	
	}
	

	void Update () {

	    transform.position = Vector2.MoveTowards(transform.position, wPs[nextWp].position, Time.deltaTime * scanSpeed);

		if (Vector2.Distance(transform.position, wPs[nextWp].position)
			< closeEnuf) {
			nextWp = (Random.Range(0, wPs.Length)) % wPs.Length;

		}

		if (isOnSight == true) {
			print("there ye are!");
			aimTimer += Time.deltaTime;
			if (aimTimer > aimTotTimer) {
				print("boom");
				aimTimer = 0;
			}
			else {
				aimTimer = 0;
			}
		}
	}

	void OnTriggerEnter2D (Collider2D c) {
		if (c.tag == "Player") {
			playerCount += 1;
			isOnSight = true;
		}
	}
	void OnTriggerExit2D (Collider2D c) {
		if (c.tag == "Player") {
			playerCount -= 1;
			if(playerCount == 0) {
		       isOnSight = false;
			}
	
		}
	} 
}
