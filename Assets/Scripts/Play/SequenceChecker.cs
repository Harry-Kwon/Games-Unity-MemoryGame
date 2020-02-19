using System;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class SequenceChecker : MonoBehaviour
{
	[Serializable]
	public class SuccessEvent : UnityEvent { }
	[Serializable]
	public class FailEvent : UnityEvent { }

	[SerializeField]
	public SuccessEvent OnSuccess = new SuccessEvent();
	[SerializeField]
	public FailEvent OnFail = new FailEvent();


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
			buttons[i].GetComponent<Button>().onClick.AddListener(() => { handleButtonClick(x); });
		}

		OnFail.AddListener(() => {
			ResetInputSequence();
		});
	}

	void handleButtonClick(int clicked)
	{
		if (position >= generator.currentSequence.Count) { return; }

		if(clicked == (int) generator.currentSequence[position])
		{
			// play good animation
			position++;
			progressBar.ColorBar(clicked);

			if(position >= generator.currentSequence.Count)
			{
				OnSuccess.Invoke();
			}
		} else
		{
			OnFail.Invoke();
		}
	}

	public void ResetInputSequence()
	{
		position = 0;
	}

}
