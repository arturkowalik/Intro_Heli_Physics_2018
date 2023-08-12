using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
	public class IP_Heli_Engine : MonoBehaviour
	{
		#region Variables
		public float maxHP = 140f;
		public float maxRPM = 2700;
		public float powerDelay = 2f;
		#endregion
		
		
		
		#region Properties
		private float currentHP;
		public float CurrentHP
		{
			get { return currentHP; }
		}
		
		private float currentRPM;
		public float CurrentRPM
		{
			get { return currentHP; }
		}
		
		#endregion
		
		
		
		#region BuiltIn Methods
	    // Start is called before the first frame update
	    void Start()
	    {
	        
	    }
	    #endregion
	    
		#region Custom MEthods
		public void UpdateEngine(float throttleInput)
		{
			Debug.Log(throttleInput);
			Debug.Log("Hazboulah");
		}
		#endregion
		

	}
}