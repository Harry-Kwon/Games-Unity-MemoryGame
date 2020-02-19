using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlaySequenceButton : MonoBehaviour
{
	Text buttonText;
	public string successText = "Next";
	public string defaultText = "Play";

	public void HandleInputSuccess() {
		buttonText.text = successText; 
	}

	public void ResetText()
	{
		buttonText.text = defaultText;
	}


	private void Awake()
	{
		buttonText = GetComponentInChildren<Text>();
	}

	private void Start()
	{
		ResetText();
	}
}
