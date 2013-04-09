using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class Bullet : MonoBehaviour
	{
		public float mySpeed = 5.0f;
	    public float myRange = 1.5f;
	    private float myDist;
		

		
		void Start() {
			GameObject.Destroy(gameObject, 5f);	
		}
		
		
		void Update ()
		{
			//transform.position += Vector3.right * Time.deltaTime * mySpeed;
	        transform.Translate (Vector3.forward * Time.deltaTime * mySpeed);
	        myDist += Time.deltaTime * mySpeed;

		}
		
		void OnCollisionEnter(Collision col)
		{
			Debug.Log ("COLLISION");
			//col.gameObject.SendMessageUpwards("RecieveDamage", Damage, SendMessageOptions.DontRequireReceiver);
			Destroy(gameObject);
		}
		
		public void OnTriggerEnter(Collider col){
			Debug.Log ("TRIGGER");
			Destroy(gameObject);
		}
	}
}
