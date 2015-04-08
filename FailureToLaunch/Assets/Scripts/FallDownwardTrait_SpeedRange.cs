using UnityEngine;
using System.Collections;

public class FallDownwardTrait_SpeedRange : FallDownwardTrait {
//	[HideInInspector] float fallSpeed;
	[SerializeField] float
		minFallSpeed,
		maxFallSpeed;
	// Use this for initialization
	void Awake () {
		speed = UnityEngine.Random.Range (minFallSpeed, maxFallSpeed);
	}

}
