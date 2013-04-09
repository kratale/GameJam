using UnityEngine;
using System.Collections;

namespace AssemblyCSharp
{
	public class DumbFollow1D : MonoBehaviour {
		public float speed;
		public GameObject target;
		
		CharacterController cc;
		void Start () {
			cc = GetComponent<CharacterController>();
		}
	
		void FixedUpdate () {
			if(cc) {
				cc.SimpleMove(new Vector3(speed * -Mathf.Sign(transform.position.x - target.transform.position.x), 0, 0));
			}
		}
	}
}