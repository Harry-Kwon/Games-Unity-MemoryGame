using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
	public int Score { get; private set; }

	int nextIncrement;

	public void IncrementScore()
	{
		Score += nextIncrement;
		nextIncrement++;
		SetScoreText();
	}

	public void ResetScore()
	{
		Score = 0;
		nextIncrement = 1;
		SetScoreText();
	}


	Text scoreText;
	private void Start()
	{
		scoreText = GetComponentInChildren<Text>();

		ResetScore();
	}

	void SetScoreText()
	{
		scoreText.text = "Score: " + Score;
	}
}
