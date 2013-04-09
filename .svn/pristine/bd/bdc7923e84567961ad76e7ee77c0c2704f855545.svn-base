using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	public class Player : MonoBehaviour {
		public GameObject gameOverObject;
		public string startOverAt;
		public float power;
		public float drainRate;
		
		public List<PowerUp> currPowerUps;
	
		//public List<Items> items;	
		private float currPower;
		bool gameOver;
	
		void Start () {
			gameOverObject.renderer.enabled = false;
			gameOver = false;
			currPower = power;
			currPowerUps = new List<PowerUp>();
			//items = new List<Items>();
		}
		
		void Update() {
			if(gameOver) {
				if(Input.anyKeyDown) {
					Application.LoadLevel(startOverAt);	
				}
			}
			currPower -= drainRate * Time.deltaTime;
			if(currPower <= 0) {
				currPower = 0;
				Die ();	
			}
			
			for(int i = 0; i < currPowerUps.Count; i++){
				PowerUp p = currPowerUps[i];
				if(p.StartTime + p.Duration < Time.time){
					p.RestoreNormal(this);
					currPowerUps.RemoveAt(i);
					GameObject.Destroy(p);
					i--;
				}
			}			
		}
		
		public void Die() {
			//when the player dies, its gg
			gameOverObject.renderer.enabled = true;		
			gameOverObject.transform.position = transform.position - new Vector3(4,0,0);
			foreach(Renderer r in GetComponentsInChildren<Renderer>()) {		
				r.enabled = false;	
			}
			gameOver = true;
		}
		
		public float GetMaxPower() {
			return power;	
		}
		
		public float GetPower() {
			return currPower;	
		}
		
		
		public void Pickup(PowerUp power)
		{
			currPowerUps.Add(power);
			power.Effect(this);
		}
		
		public void OnControllerColliderHit(ControllerColliderHit col) {
			if(col.gameObject.tag.Equals("Lethal")) {
				Die ();	
			}
		}
		
		public void OnTriggerEnter(Collider col){
			if(col.gameObject.tag.Equals("PowerUp")){
				PowerUp powerUp = col.gameObject.GetComponent<PowerUp>();
				Pickup(powerUp);
				//GameObject.Destroy(col.gameObject);
				col.collider.enabled = false;
				col.gameObject.renderer.enabled = false;
				col.gameObject.particleSystem.enableEmission = false;
			}
			
			if(col.gameObject.tag.Equals ("Bullet")){
				currPower -= 15;	
			}
		}
	}
}
