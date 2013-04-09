using UnityEngine;
using System.Collections;

namespace AssemblyCSharp{
	public class PlayerGUI : MonoBehaviour {
		public Rect powerBar;
		public Texture powerBGTexture;
		public Texture powerTexture;
		
		public Player target;
		
		void Start () {
			
		}
		
		void Update () {
		
		}
	
		void OnGUI() {
			float currPower = target.GetPower();
			
			float power = target.GetMaxPower();
			Rect filled = powerBar;
			filled.height = powerBar.height * (currPower / power);
			filled.y = (powerBar.height - filled.height);
			GUI.DrawTexture(powerBar, powerBGTexture);
			GUI.DrawTexture(filled, powerTexture);
		}
	}
}