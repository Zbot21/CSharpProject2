using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scoring : MonoBehaviour {

	public int pointsPerCoin;
	public int score;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		score = 0;
	}

	public void addScore() {
		score += pointsPerCoin;
	}

	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + score;
	}
}
