using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSaver : MonoBehaviour
{
	public ScoreKeeper scoreKeeper;
	private void OnEnable()
	{
		SaveScore(scoreKeeper.Score);
	}

	public void SaveScore(int newScore)
    {
		int[] scores = new int[10];
		for(int i=0; i<scores.Length; i++)
		{
			scores[i] = PlayerPrefs.GetInt($"score{i}", 0);
		}

		if(newScore > scores[scores.Length-1])
		{
			scores[scores.Length - 1] = newScore;
			System.Array.Sort(scores);
			System.Array.Reverse(scores);


			for(int i=0; i<scores.Length; i++)
			{
				PlayerPrefs.SetInt($"score{i}", scores[i]);
				Debug.Log(i + ", " + scores[i]);
			}
		}
    }
}
