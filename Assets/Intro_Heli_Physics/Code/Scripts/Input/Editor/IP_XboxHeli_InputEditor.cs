﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace IndiePixel
{
	[CustomEditor(typeof(IP_XboxHeli_Input)), CanEditMultipleObjects]
	public class IP_XboxHeli_InputEditor : Editor
	{
		#region Variables
		IP_XboxHeli_Input targetInput;
        #endregion

        #region BuiltIn Methods
		private void OnEnable()
		{
			targetInput = (IP_XboxHeli_Input)target;
		}

		public override void OnInspectorGUI()
		{
			base.OnInspectorGUI(); // Use this instead of base.OnInspectorGUI()

			DrawDebugUI();

			Repaint();
		}
        #endregion

        #region CustomMethods
		void DrawDebugUI()
		{
			EditorGUILayout.BeginVertical(EditorStyles.helpBox);
			EditorGUILayout.Space();

			EditorGUI.indentLevel++;
			EditorGUILayout.LabelField("Throttle: " + targetInput.ThrottleInput.ToString("0.00"), EditorStyles.boldLabel);
			EditorGUILayout.LabelField("Collective: " + targetInput.CollectiveInput.ToString("0.00"), EditorStyles.boldLabel);
			EditorGUILayout.LabelField("Cyclic: " + targetInput.CyclicInput.ToString("0.00"), EditorStyles.boldLabel);
			EditorGUILayout.LabelField("Pedal: " + targetInput.PedalInput.ToString("0.00"), EditorStyles.boldLabel);
			EditorGUI.indentLevel--;
			
			EditorGUILayout.Space();
			EditorGUILayout.EndVertical();
		}
        #endregion
	}
}