using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
	public Color[] colors;
	public Color defaultColor;
	public GameObject barPrefab;

	List<GameObject> bars;
	private int current = 0;

	public void AddBar()
	{
		GameObject b = (GameObject) Instantiate(barPrefab, transform);
		bars.Add(b);
	}

	public void Reset()
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

	public void Start()
	{
		bars = new List<GameObject>();
		AddBar();
	}
}
