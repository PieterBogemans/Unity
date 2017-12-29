using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	

	public void LoadLevel(string name) 
	{
		Application.LoadLevel(name);
	}
	
	public void Quitrequest() 
	{
		Application.Quit();
	}
	
	public void LoadNextLevel() 
	{
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
