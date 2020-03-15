using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeController : MonoBehaviour
{
	public void setVolume(float newVolume)
	{
		PlayerPrefs.SetFloat("volume", newVolume);
		AudioListener.volume = PlayerPrefs.GetFloat("volume");
	}
}
