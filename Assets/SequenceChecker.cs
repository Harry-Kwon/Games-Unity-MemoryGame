using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SequenceChecker : MonoBehaviour
{
	int position = 0;
	public GameObject[] buttons;
	public SequenceGenerator generator;

	public Animator anim;

	public ProgressBar progressBar;


	public void Start()
	{
		anim = GetComponent<Animator>();
		for(int i=0; i<buttons.Length; i++)
		{
			int x = i;
			buttons[i].GetComponent<Button>().onClick.AddListener(() => { handleClick(x); });
		}
	}

	void handleClick(int clicked)
	{
		if (position >= generator.currentSequence.Count) { return; }

		if(clicked == (int) generator.currentSequence[position])
		{
			// play good animation
			position++;

			progressBar.ColorBar(clicked);

			if(position >= generator.currentSequence.Count)
			{
				// play success sound
				generator.OnInputSuccess();
			}
		} else
		{
			OnFail();
		}
	}

	public void OnFail()
	{
		anim.Play("Fail");
		ResetInputSequence();
	}

	public void ResetInputSequence()
	{
		position = 0;
		progressBar.Reset();
	}

}
