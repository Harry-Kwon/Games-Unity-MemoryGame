using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StateManager : MonoBehaviour
{
	public string defaultState;
	public static StateController currentState;
	public static Dictionary<string, StateController> states = new Dictionary<string, StateController>();

	public static class States
	{
		public static string Menu = "Menu";
		public static string Scores = "Scores";
		public static string Play = "Play";
		public static string Options = "Options";
	}

	public static void RegisterState(StateController state)
	{
		states.Add(state.stateName, state);
		Debug.Log("Added State: " + state.stateName);
	}

	public static void TransitionState(string nextState)
	{
		StateController next = states[nextState];

		// exit current state
		currentState.ExitState();

		// enter new state
		next.EnterState();

		// update current state
		currentState = next;
	}

	public void TransitionToState(string state)
	{
		TransitionState(state);
	}

	void Awake()
    {
		// set current state to default state
		if(states.ContainsKey(defaultState))
		{
			currentState = states[defaultState];
		} else
		{
			throw new System.Exception("Could not find default state");
		}

		// disable all states but default state
		foreach(StateController s in states.Values)
		{
			s.ExitState();
		}

		currentState.EnterState();
    }
}
