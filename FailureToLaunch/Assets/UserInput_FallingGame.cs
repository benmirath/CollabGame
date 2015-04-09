using UnityEngine;
using System.Collections;

public class UserInput_FallingGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Left"))
			transform.Translate (Vector3.left * 1);
		else if (Input.GetButton ("Right"))
			transform.Translate (Vector3.right * 1);

	}
}
