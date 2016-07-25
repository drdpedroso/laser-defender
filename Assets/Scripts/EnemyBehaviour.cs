using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D collider){
		Projectile missile = collider.gameObject.GetComponent<Projectile>();
		if(missile){
			Debug.Log("Hit by a projectile");
		}
		
	}
	
}
