using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System;

public class ButtonDown : MonoBehaviour, IPointerDownHandler
{
	[Serializable]
	public class ButtonDownEvent : UnityEvent { }

	[SerializeField]
	public ButtonDownEvent onButtonDown = new ButtonDownEvent();

	public void OnPointerDown(PointerEventData data)
	{
		onButtonDown.Invoke();
	}
}
