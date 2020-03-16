using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLoader : MonoBehaviour
{
	public GameObject RowPrefab;
	public GameObject Container;

    void OnEnable()
    {
		int[] scores = new int[10];
		for(int i=0; i<scores.Length; i++)
		{
			scores[i] = PlayerPrefs.GetInt($"score{i}", 0);
		}
		Debug.Log(scores);

		SetScores(scores);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	private void SetScores(int[] sortedScoreData)
	{
		int rows = 10;//Mathf.Min(sortedScoreData.Length, Container.transform.childCount);
		for (int i = 0; i < rows; i++)
		{
			Transform row = Container.transform.GetChild(i);
			row.GetChild(0).GetComponentInChildren<Text>().text = ""+(i+1);
			row.GetChild(1).GetComponentInChildren<Text>().text = ""+sortedScoreData[i];
		}
	}
}
