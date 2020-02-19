using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesTracker : MonoBehaviour
{
	public const int InitialLives = 3;
	public int Lives { get; private set; }

	public Transform IconsContainer;

	public void ResetLives()
	{
		Lives = InitialLives;

		for(int i=0; i<IconsContainer.childCount; i++)
		{
			IconsContainer.GetChild(i).gameObject.SetActive(true);
		}
	}

	public void LoseLife()
	{
		Lives = Mathf.Max(0, Lives-1);
		IconsContainer.GetChild(Lives).gameObject.SetActive(false);
	}

	public void GainLife()
	{
		Lives = Mathf.Min(InitialLives, Lives+1);
		IconsContainer.GetChild(Lives - 1).gameObject.SetActive(true);
	}

	private void Start()
	{
		ResetLives();
	}
}
