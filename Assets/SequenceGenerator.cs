using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SequenceGenerator : MonoBehaviour
{
	public enum Color { Red, Green, Yellow, Blue }
	public string[] s = {"Red", "Green", "Yellow", "Blue"};
	public List<Color> currentSequence;

	Animator anim;

	private int nextAnim;

	public bool playing = false;
	public bool inputSuccess = false;

	public ProgressBar progressBar;

	public void StartSequence()
	{
		currentSequence = new List<Color>();
		GenerateSequence();
	}

	public List<Color> GenerateSequence()
	{
		Color nextColor = (Color) Random.Range(0, 4);
		currentSequence.Add(nextColor);
		return currentSequence;
	}
	
	public void StartAnimation()
	{
		nextAnim = 0;
		playing = true;
		OnAnimationEnd();
	}

	public void OnAnimationEnd()
	{
		if(playing)
		{
			if(nextAnim < currentSequence.Count)
			{
				// play animation for current button
				anim.Play(s[(int) currentSequence[nextAnim]]);
				nextAnim++;
			} else {
				playing = false;
			}
		}
	}

	public void StopOutputSequence()
	{
		playing = false;
	}

	public void OnInputSuccess()
	{
		inputSuccess = true;
	}

	public void OnPlayButton()
	{
		if (inputSuccess)
		{
			GenerateSequence();
			progressBar.AddBar();
			inputSuccess = false;
		}

		StartAnimation();
	}

    void Start()
    {
		StartSequence();
		anim = GetComponent<Animator>();
    }
}
