﻿using UnityEngine;
using System;
using System.Collections;

public class StickyNoteTrait : MonoBehaviour {
	enum StickyNoteColors {
		Yellow,
		Blue,
		Red,
		Green
	}

	Rigidbody2D rigid;
	SpriteRenderer sprite;

	[SerializeField] StickyNoteColors stickyNoteColor;

	void Awake () {
		rigid = GetComponent<Rigidbody2D> ();
		sprite = GetComponent<SpriteRenderer> ();

		stickyNoteColor = (StickyNoteColors)UnityEngine.Random.Range (0, Enum.GetValues (typeof(StickyNoteColors)).Length);

		switch (stickyNoteColor) {
		default:
		case StickyNoteColors.Yellow:
			sprite.color = Color.yellow;
			break;
		case StickyNoteColors.Blue:
			sprite.color = Color.blue;
			break;
		case StickyNoteColors.Red:
			sprite.color = Color.red;
			break;
		case StickyNoteColors.Green:
			sprite.color = Color.green;
			break;
		}
		Debug.LogError ("Boop");
	}


}
