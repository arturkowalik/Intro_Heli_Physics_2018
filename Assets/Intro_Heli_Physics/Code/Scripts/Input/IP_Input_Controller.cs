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
	
	public class IP_Input_Controller : MonoBehaviour
	{
		#region Variables
		public InputType inputType = InputType.Keyboard;
		
		[Header("Input Components")]
		public IP_KeyboardHeli_Input keyInput;
		public IP_XboxHeli_Input xboxInput;
		#endregion
		
		#region BuiltIn Methods
	    void Start()
	    {
		    SetInputType(inputType);
	    }
		#endregion
		
		
		#region Custom Methods
		void SetInputType(InputType type)
		{
			if(keyInput && xboxInput)
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

		}
		
		#endregion
	}
}




























//sdas