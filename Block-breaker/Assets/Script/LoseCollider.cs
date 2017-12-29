using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelmanager; 
	void OnTriggerEnter2D (Collider2D collision) {
		levelmanager = GameObject.FindObjectOfType<LevelManager>();
		levelmanager.LoadLevel("Lose");
	}	
	
	
	void onCollisionEnter2D(Collider2D collision) {
		
	}
}
