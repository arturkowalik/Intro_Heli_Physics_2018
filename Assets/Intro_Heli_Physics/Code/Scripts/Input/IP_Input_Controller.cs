using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace IndiePixel
{
	public enum InputType
	{
		Keyboard, 
		Xbox, 
		Mobile,
	}
	
	[RequireComponent(typeof(IP_KeyboardHeli_Input), typeof(IP_XboxHeli_Input))]
	public class IP_Input_Controller : MonoBehaviour
	{
		#region Variables
		[Header("Input Properties")]
		public InputType inputType = InputType.Keyboard;
		
		private IP_KeyboardHeli_Input keyInput;
		private IP_XboxHeli_Input xboxInput;
		#endregion
		
		
		#region BuiltIn Methods
	    void Start()
		{
			keyInput = GetComponent<IP_KeyboardHeli_Input>();
			xboxInput = GetComponent<IP_XboxHeli_Input>(); 
			
			if(keyInput && xboxInput)
			{
				SetInputType(inputType);
			}
	    }
		#endregion
		
		
		 
		 
		#region Custom Methods
		void SetInputType(InputType type)
		{
			if(type == InputType.Keyboard)
			{
				keyInput.enabled = true;
				xboxInput.enabled = false;
			}
			
			if(type == InputType.Xbox)
			{
				xboxInput.enabled = true;
				keyInput.enabled = false;
			} 
		}
		
		#endregion
	}
}




























//sdas