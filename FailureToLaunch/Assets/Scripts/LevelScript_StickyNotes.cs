using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public interface ILevelScript {
	int CurrentScore { get; }
	void UpdateScore (int val);
	
}

public class LevelScript_StickyNotes : MonoBehaviour, ILevelScript {
	[SerializeField] StickyNoteTrait
		yellowStickyKeyCode,
		redStickyKeyCode,
		greenStickyKeyCode,
		blueStickyKeyCode;

	[SerializeField] float 
		gameDuration,
		fireRate;

	[SerializeField] StickyNoteTrait stickyNotePrefab;

	[SerializeField] Transform scoreZone;
	[SerializeField] Text scoreText;

	SpriteRenderer scoreZoneRenderer;

	int currentScore;
	StickyNoteColors currentStickyNoteColor;

	public int CurrentScore { get { return currentScore; } }
	public StickyNoteColors CurrentStickyNoteColor { get { return currentStickyNoteColor; } }

	public void UpdateScore (int val) {
		currentScore += val;
		scoreText.text = currentScore.ToString ();
	}
	public void UpdateColor (StickyNoteColors color) {
		currentStickyNoteColor = color;


	}

	List<StickyNoteTrait> stickies = new List<StickyNoteTrait> ();

	void Awake () {
		scoreZoneRenderer = scoreZone.GetComponent<SpriteRenderer> ();
	}

	IEnumerator Start () {
		currentScore = 0;
		scoreText.text = currentScore.ToString ();

		float timer = Time.time + gameDuration;
		while (timer > Time.time) {
			StickyNoteTrait sticky = Instantiate (
				stickyNotePrefab, 
				Camera.main.ViewportToWorldPoint(new Vector3 (UnityEngine.Random.Range(0.1f, 0.9f), 1, 10)), 
				Quaternion.identity
			) as StickyNoteTrait;

			stickies.Add (sticky);
			yield return new WaitForSeconds (fireRate);
		}
	}

	void Update () {
		///foreach sticky
		/// check if past scoreZone
		///	check if currentSelectedSticky == sticky color
		/// 	score +
		/// else
		/// 	score -
		/// 
	}

	static Color StickyNoteColor (StickyNoteColors color) {
		Color returnVal = Color.white;
		switch (color) {
		default:
		case StickyNoteColors.Yellow:
			returnVal = Color.yellow;
			break;
		case StickyNoteColors.Blue:
			returnVal = Color.blue;
			break;
		case StickyNoteColors.Red:
			returnVal = Color.red;
			break;
		case StickyNoteColors.Green:
			returnVal = Color.green;
			break;
		}
		return returnVal;
	}
}

