using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SharedTextParent))]
public class SharedTextParentEditor : Editor
{
	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();

		SharedTextParent script = (SharedTextParent)target;
		/*if(GUILayout.Button("Resize"))
		{
			script.SetSharedTextSize();
		}*/
	}
}
