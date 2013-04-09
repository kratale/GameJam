using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class Regen : PowerUp
	{
		public Regen ()
			: base()
		{
			duration = 3.0f;	
		}
		
		public override void Effect(Player playerCharacter){
			playerCharacter.drainRate = playerCharacter.drainRate - 4;
			startTime = Time.time;
		}
		
		public override void RestoreNormal(Player playerCharacter){
			playerCharacter.drainRate = playerCharacter.drainRate + 4;
		}
	}
}

