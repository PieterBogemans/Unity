using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public Sprite[] hitSprites; 
	public int maxHits; 
	private int timesHit; 
	private LevelManager levelmanager;

	// Use this for initialization
	void Start () {
		timesHit = 0;
		levelmanager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionExit2D (Collision2D col) 
	{
		timesHit++;
		if (timesHit >= maxHits) 
		{
			Destroy(gameObject);
		} 
		else 
		{
			LoadSprites();
		}
		
	}
	
	void LoadSprites() 
	{
		int spriteIndex = timesHit - 1;
		this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
	}
	
	
	//TODO Remove this method once we can actually win. 
	void SimulateWin()
	{
		levelmanager.LoadNextLevel();
	}
}
