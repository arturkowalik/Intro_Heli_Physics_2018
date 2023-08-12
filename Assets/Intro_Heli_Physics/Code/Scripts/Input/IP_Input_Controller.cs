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
		
		private float throttleInput;
		public float ThrottleInput
		{
			get { return throttleInput; }
		}
		
		private float collectiveInput;
		public float CollectiveInput
		{
			get { return collectiveInput; }
		}
		
		private Vector2 cyclicInput;
		public Vector2 CyclicInput
		{
			get { return cyclicInput; }
		}
		
		private float pedalInput;
		public float PedalInput
		{
			get { return pedalInput; }
		}
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
	    
		private void Update()
		{
			if(keyInput && xboxInput)
			{
				switch(inputType)
				{
				case InputType.Keyboard:
					throttleInput = keyInput.ThrottleInput;
					collectiveInput = keyInput.CollectiveInput;
					cyclicInput = keyInput.CyclicInput;
					pedalInput = keyInput.PedalInput;
					break;		
					
				case InputType.Xbox:
					throttleInput = xboxInput.ThrottleInput;
					collectiveInput = xboxInput.CollectiveInput;
					cyclicInput = xboxInput.CyclicInput;
					pedalInput = xboxInput.PedalInput;
					break;
					
				default:
					break;
				}
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