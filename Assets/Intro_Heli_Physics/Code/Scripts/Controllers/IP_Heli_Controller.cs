using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
	[RequireComponent(typeof(IP_Input_Controller), typeof(IP_KeyboardHeli_Input), typeof(IP_XboxHeli_Input))]	
	public class IP_Heli_Controller : IP_Base_RBController
	{
		#region Variables
		//[Header("Controller Properties")]
		private IP_Input_Controller input;
		#endregion
	
		void Start()
		{
			input = GetComponent<IP_Input_Controller>();
		}
	
		#region Custom Methods	
		protected override void HandlePhysics()
		{
			
			if	(input)
			{
				HandleEngines();
				HandleCharacteristics();
			}
		}	
		#endregion
	
	
	
		#region Helicopter Controler Methods
		protected virtual void HandleEngines()
		{
			
		}
		
		protected virtual void HandleCharacteristics()
		{
			
		}
		#endregion

	}
}