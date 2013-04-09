using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class PowerUp : MonoBehaviour
	{
		protected float duration;
		protected float startTime = 0;
		
		public PowerUp()
		{

		}
	
	    public virtual void Effect(Player playerCharacter){
			
		}
		
		public virtual void RestoreNormal(Player playerCharacter){
			
		}
		
		public float StartTime{
			get { return startTime; }	
		}
		public float Duration{
			get { return duration; }	
		}
	}
}
