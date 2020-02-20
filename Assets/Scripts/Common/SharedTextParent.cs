using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SharedTextParent : MonoBehaviour
{
	public void SetSharedTextSize()
	{
		int minSize = 999999;

		Text[] textComponents = GetComponentsInChildren<Text>();

		foreach(Text t in textComponents)
		{
			int fontSize = t.cachedTextGenerator.fontSizeUsedForBestFit;
			Debug.Log(t.cachedTextGeneratorForLayout.fontSizeUsedForBestFit);
			Debug.Log(fontSize);
			if(fontSize < minSize)
			{
				minSize = fontSize;
				Debug.Log(minSize);
			}
		}

		foreach(Text t in textComponents)
		{
			t.resizeTextForBestFit = false;
			t.fontSize = minSize;
		}
	}

	bool resized = false;

	private void Update()
	{
		if(!resized)
		{
			SetSharedTextSize();
			resized = true;
		}
	}
}
