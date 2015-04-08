using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelScript_StickyNotes : MonoBehaviour, ILevelScript {
	[SerializeField] float 
		gameDuration,
		fireRate;
	[SerializeField] StickyNoteTrait stickyNotePrefab;
	[SerializeField] ScoreZoneTrait scoreZone;

	int currentScore;

	public int CurrentScore { get { return currentScore; } }
	public void UpdateScore (int val) {
		currentScore += val;
	}

	List<StickyNoteTrait> stickies = new List<StickyNoteTrait> ();

	IEnumerator Start () {
		currentScore = 0;
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
}

public interface ILevelScript {
	int CurrentScore { get; }
	void UpdateScore (int val);

}