using UnityEngine;

public class PhysicsExample : MonoBehaviour {
	void OnCollisionEnter2D (Collision2D hit) {
		if (hit.gameObject.CompareTag ("Collectible")) {
			Debug.Log ("WORKING");
		} else {
			Debug.Log ("NOT WORKING");
		}
		
	}
	
	

}


