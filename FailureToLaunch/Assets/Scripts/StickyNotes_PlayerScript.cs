using UnityEngine;


public class StickyNotes_PlayerScript : MonoBehaviour {
	[SerializeField] string
		yellowStickyKeyCode,
		redStickyKeyCode,
		greenStickyKeyCode,
		blueStickyKeyCode;

	StickyNoteColors currentStickyColor;
	public StickyNoteColors CurrentStickyColor { get { return currentStickyColor; } }

	public delegate void PlayerInputEntered (StickyNotes_PlayerScript playerScript);
	public static event PlayerInputEntered OnPlayerInputEntered;

	void Update () {
		if (Input.GetKeyDown (yellowStickyKeyCode)) {
		
		} else if (Input.GetKeyDown (redStickyKeyCode)) {

		} else if (Input.GetKeyDown (greenStickyKeyCode)) {
		
		} else if (Input.GetKeyDown (blueStickyKeyCode)) {
		
		}
	}

}
