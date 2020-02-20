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
	
	void Start()
	{
		GetComponent<Image>().alphaHitTestMinimumThreshold = 1.0f;
	}

	public void OnPointerDown(PointerEventData data)
	{
		onButtonDown.Invoke();
	}
}
