using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToMenuButton : MonoBehaviour
{
	public void ToMenu()
	{
		StateManager.TransitionState(StateManager.States.Menu);
	}
}
