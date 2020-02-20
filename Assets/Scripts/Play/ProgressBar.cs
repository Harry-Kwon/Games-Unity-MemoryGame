using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
	public Color[] colors;
	public Color defaultColor;
	public GameObject barPrefab;

	List<GameObject> bars = new List<GameObject>();
	private int current = 0;

	public void AddBar()
	{
		GameObject b = (GameObject) Instantiate(barPrefab, transform);
		bars.Add(b);
		Debug.Log(bars.Count);
	}

	public void ResetColors()
	{
		current = 0;
		foreach(GameObject g in bars)
		{
			Debug.Log('a');
			g.GetComponent<Image>().color = defaultColor;
		}
	}

	public void ColorBar(int c)
	{
		bars[current].GetComponent<Image>().color = colors[c];
		current++;
	}

	public void Reset()
	{
		// destroy children
		for(int i=0; i<transform.childCount; i++)
		{
			Destroy(transform.GetChild(i).gameObject);
		}

		bars = new List<GameObject>();
		AddBar();
		current = 0;
	}

	public void Start()
	{
		Reset();
	}
}
