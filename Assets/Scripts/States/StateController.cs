using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour
{
	public string stateName;

	public void ExitState()
	{
		for(int i=0; i<transform.childCount; i++)
		{
			transform.GetChild(i).gameObject.SetActive(false);
		}
	}

	public void EnterState()
	{
		for(int i=0; i<transform.childCount; i++)
		{
			transform.GetChild(i).gameObject.SetActive(true);
		}
	}

	private void Awake()
	{
		StateManager.RegisterState(this);
	}
}
