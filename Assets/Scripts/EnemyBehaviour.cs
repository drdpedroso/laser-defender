using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {
	
	public GameObject projectile;
	public float projectileSpeed = 10f;
	public float healt = 150f;
	
	
	void Update(){
		Vector3 startPosition = transform.position + new Vector3(0, -1, 0);
		GameObject missile = Instantiate(projectile, startPosition, Quaternion.identity) as GameObject;
		missile.GetComponent<Rigidbody2D>().velocity = new Vector2(0,projectileSpeed);
	}
	
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
