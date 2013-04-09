using UnityEngine;
using System.Collections;

namespace AssemblyCSharp
{
	public class Living : MonoBehaviour {
		void Start () {
		
		}
	
		void Update () {
		
		}
		
		public void Die() {
			//TODO:
			Destroy(gameObject);
		}
		
		public void OnControllerColliderHit(ControllerColliderHit col) {
			if(col.gameObject.tag.Equals("Lethal")) {
				Die ();	
			}
		}
	}
}