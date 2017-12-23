using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	
	int max;
	int min;
	int guess;
	
	// Use this for initialization
	void Start () {
		StartGame (); 
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			//print("Down arrow pressed"); 
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.UpArrow)) {
			print("Up arrow pressed"); 
			min = guess; 
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print("I found your number!"); 
			StartGame (); 
			
			
		}
	}
	
	void StartGame() { 
		min = 1;
		max = 1000;
		guess = 500;
		print("Welcome to Number Wizard!"); 
		print ("Pick a number in your head, but don't tell me"); 
		
		
		
		print ("The highest number you can pick " + max + ", and the lowest number is " + min); 
		max += 1;
		print ("Is the number higher or lower than "+ guess + "?");
		print ("Up arrow for higher, down for lower return for equal");
		
	}
	
	void NextGuess () {
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess);
	}
}
