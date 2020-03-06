using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class StateController : MonoBehaviour
{
	public string stateName;

	public virtual void ExitState()
	{
		Debug.Log("Exiting State");
		for(int i=0; i<transform.childCount; i++)
		{
			transform.GetChild(i).gameObject.SetActive(false);
		}
		OnExitState.Invoke();
	}

	public virtual void EnterState()
	{
		Debug.Log("Entering State");
		for(int i=0; i<transform.childCount; i++)
		{
			transform.GetChild(i).gameObject.SetActive(true);
		}
		OnEnterState.Invoke();
	}

	[Serializable]
	public class EnterStateEvent : UnityEvent { }
	[SerializeField]
	public EnterStateEvent OnEnterState = new EnterStateEvent();

	[Serializable]
	public class ExitStateEvent : UnityEvent { }
	[SerializeField]
	public ExitStateEvent OnExitState = new ExitStateEvent();

	private void Awake()
	{
		StateManager.RegisterState(this);
	}
}
