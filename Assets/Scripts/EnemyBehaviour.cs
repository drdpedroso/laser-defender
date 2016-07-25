using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {

	public float healt = 150f;
	
	void OnTriggerEnter2D(Collider2D collider){
		Projectile missile = collider.gameObject.GetComponent<Projectile>();
		if(missile){
		    healt -= missile.GetDamage();
		    missile.Hit();
		    if(healt <= 0){
		    	Destroy(gameObject);
		    }
		}
		
	}
	
}
