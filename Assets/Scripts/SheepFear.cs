using UnityEngine;
using System.Collections;

public class SheepFear : MonoBehaviour {
	public GameObject player;
	bool fear = false;
	float maxSpeed = 20;
	// Use this for initialization
	void Start () {
		//player = GameObject.FindWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		float playerDist = Vector3.Distance (player.transform.position, transform.position);
		if (playerDist < 14) {
			fear = true;
			fleePlayer ();
		} else {
			if (fear == true) {
				fear = false;
			}
		}
	}
	void fleePlayer(){
		Vector3 direction = transform.position - player.transform.position;
		direction.Normalize ();
		float speed = maxSpeed - Vector3.Distance (player.transform.position, transform.position);
		float step = speed * Time.deltaTime;
		transform.Translate (direction.x * step, 0, direction.z*step);
	}
	public bool fearStatus(){
		return fear;
	}
}
