using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLoader : MonoBehaviour
{
	public GameObject RowPrefab;
	public GameObject Container;

    void Start()
    {
		ScoreData[] scores = new ScoreData[10];
		for(int i=0; i<scores.Length; i++)
		{
			scores[i] = new ScoreData("AAA", Random.Range(0, 100000));
		}
		SetScores(scores);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	private void SetScores(ScoreData[] sortedScoreData)
	{
		int rows = Mathf.Min(sortedScoreData.Length, Container.transform.childCount);
		for (int i = 0; i < rows; i++)
		{
			Transform row = Container.transform.GetChild(i);
			row.GetChild(0).GetComponentInChildren<Text>().text = ""+(i+1);
			row.GetChild(1).GetComponentInChildren<Text>().text = sortedScoreData[i].Name;
			row.GetChild(2).GetComponentInChildren<Text>().text = ""+sortedScoreData[i].Score;
		}
	}
}

public class ScoreData
{
	public string Name;
	public int Score;

	public ScoreData(string name, int score)
	{
		this.Name = name;
		this.Score = score;
	}
}
