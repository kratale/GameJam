using UnityEngine;
using System.Collections;

namespace AssemblyCSharp
{
	public class CameraFollow : MonoBehaviour {
		public Transform target;
		public float distance;
		public float height;
		
		void Start () {
		}
		
		void Update () {
			if(target) {
				transform.position = target.position - new Vector3(0,-height,distance);	
			}
		}
	}
}