using UnityEngine;
using System.Collections;

public class SheepGrouping : MonoBehaviour {
	public float speed = 10;
	public GameObject mainSheep;
	SheepFear fearScript;

	void Start() {
		fearScript = gameObject.GetComponent<SheepFear>();
	}

	void Update () {
		float sheepDist = Vector3.Distance (mainSheep.transform.position, transform.position);
		if(sheepDist >8 && !fearScript.fearStatus()) {
			cozyUp ();
		}
	}
	void cozyUp(){
		Vector3 direction =  mainSheep.transform.position - transform.position;
		direction.Normalize ();
		float step = speed * Time.deltaTime;
		transform.Translate (direction.x * step, 0, direction.z*step);

	}
}
