using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class StickyNote_UIButton : MonoBehaviour {
	LevelScript_StickyNotes stickyNoteLevel;
	Rigidbody2D rigid;
	Image image;
	
	[SerializeField] bool randomizeColor;
	[SerializeField] StickyNoteColors stickyNoteColor;
	
	void Awake () {
		stickyNoteLevel = FindObjectOfType<LevelScript_StickyNotes> ();
		rigid = GetComponent<Rigidbody2D> ();
		image = GetComponent<Image> ();
		
		if (randomizeColor) stickyNoteColor = (StickyNoteColors)UnityEngine.Random.Range (1, Enum.GetValues (typeof(StickyNoteColors)).Length);
		
		switch (stickyNoteColor) {
		default:
		case StickyNoteColors.Yellow:
			image.color = Color.yellow;
			break;
		case StickyNoteColors.Blue:
			image.color = Color.blue;
			break;
		case StickyNoteColors.Red:
			image.color = Color.red;
			break;
		case StickyNoteColors.Green:
			image.color = Color.green;
			break;
		}
	}


	public void RegisterColor () {
		stickyNoteLevel.UpdateColor (stickyNoteColor);
//		stickyNoteLevel.CurrentStickyNoteColor = stickyNoteColor;
//		stickyNoteLevel.up
	}
}
