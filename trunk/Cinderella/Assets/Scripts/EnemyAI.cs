using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class EnemyAI : MonoBehaviour
	{
		public GameObject target;
		public float distanceToTarget;
		public float maxShootDistance;
		public Transform bullet;
		public float coolDown;
		
		private float cooldown;
		
		void Start() {
			cooldown = coolDown; 
		}
		
		void Update(){
			distanceToTarget = Vector3.Distance(target.transform.position, transform.position);
			
			if(distanceToTarget < maxShootDistance && cooldown <= 0) {
				Shoot ();	
				cooldown = coolDown;
			}
			else {
				cooldown -= Time.deltaTime;	
			}
		}
		
	
		void Shoot() {
			Vector2.Angle(new Vector2(target.transform.position.x, target.transform.position.y), new Vector2(transform.position.x, transform.position.y));
			
			//Quaternion desiredRotation = Quaternion.LookRotation(target.transform.position);
			GameObject go = ((Transform)(Instantiate(bullet))).gameObject; //, transform.position, target.transform.rotation.);
			Physics.IgnoreCollision(go.collider, collider);
			go.transform.position = transform.position;
			go.transform.LookAt(target.transform);
		}
	}
}

