using UnityEngine;
using System;
using System.Collections;

public enum StickyNoteColors {
	None,
	Yellow,
	Blue,
	Red,
	Green
}

public class StickyNoteTrait : MonoBehaviour {
	Rigidbody2D rigid;
	SpriteRenderer sprite;

	[SerializeField] bool randomizeColor;
	[SerializeField] StickyNoteColors stickyNoteColor;

	void Awake () {
		rigid = GetComponent<Rigidbody2D> ();
		sprite = GetComponent<SpriteRenderer> ();

		if (randomizeColor) stickyNoteColor = (StickyNoteColors)UnityEngine.Random.Range (1, Enum.GetValues (typeof(StickyNoteColors)).Length);

//		switch (stickyNoteColor) {
//		default:
//		case StickyNoteColors.Yellow:
//			sprite.color = Color.yellow;
//			break;
//		case StickyNoteColors.Blue:
//			sprite.color = Color.blue;
//			break;
//		case StickyNoteColors.Red:
//			sprite.color = Color.red;
//			break;
//		case StickyNoteColors.Green:
//			sprite.color = Color.green;
//			break;
//		}
	}


}
