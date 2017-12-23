using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	
	float mousePosInBlocks; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f); 
		mousePosInBlocks = Mathf.Clamp(Input.mousePosition.x / Screen.width * 16f, 0.5f , 15.5f) ;
		paddlePos.x = mousePosInBlocks; 
		
		this.transform.position = paddlePos; 
	}
}
