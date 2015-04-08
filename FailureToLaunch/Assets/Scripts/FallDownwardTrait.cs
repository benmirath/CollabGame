using UnityEngine;
using System.Collections;

public class FallDownwardTrait : MonoBehaviour {
	[SerializeField] float fallSpeed;

	protected float speed;
	protected virtual void Awake () {
		speed = fallSpeed;
	}

	protected virtual void Update () {
		transform.Translate ((Vector3.down * speed) * Time.deltaTime);
	}

}
