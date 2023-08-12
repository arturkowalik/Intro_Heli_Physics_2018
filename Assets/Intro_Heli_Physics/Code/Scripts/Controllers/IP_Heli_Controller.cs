using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
	[RequireComponent(typeof(IP_Input_Controller), typeof(IP_KeyboardHeli_Input), typeof(IP_XboxHeli_Input))]	
	public class IP_Heli_Controller : IP_Base_RBController
	{
		#region Variables
		[Header("Helicopter Properties")]
		public List<IP_Heli_Engine> engines = new List<IP_Heli_Engine>();
		
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
			for(int i = 0; i < engines.Count; i++)
			{
				engines[i].UpdateEngine(input.ThrottleInput);			
			}
		}
		
		protected virtual void HandleCharacteristics()
		{
			
		}
		#endregion

	}
}