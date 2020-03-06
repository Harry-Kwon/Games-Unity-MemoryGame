using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuStateController : StateController 
{
	new const string stateName = "Menu";

	public override void ExitState()
	{
		// default behavior is to disable child objects
		// default behavior not called to persist menu sounds
		//base.ExitState();
		OnExitState.Invoke();
	}

	public void OnExitButton()
	{
		// exit game
		this.ExitState();
		Debug.Log("Exiting Game");
		Application.Quit();
	}

	public void OnScoreButton()
	{
		// transition to score state
		StateManager.TransitionState(StateManager.States.Scores);
	}

	public void OnStartButton()
	{
		// transition to play state
		StateManager.TransitionState(StateManager.States.Play);
	}

	public void OnOptionsButton()
	{
		// transition to play state
		StateManager.TransitionState(StateManager.States.Options);
	}
	
}
