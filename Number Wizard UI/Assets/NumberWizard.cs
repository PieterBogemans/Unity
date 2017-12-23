using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	
	int max;
	int min;
	int guess;
	
	int maxGuessesAllowed = 11; 
	
	public Text text;
	
	// Use this for initialization
	void Start () {
		StartGame (); 
		
	}
	
	
	
	void StartGame() { 
		min = 1;
		max = 1000;
		NextGuess();
		
	}
	
	void NextGuess () {
		guess = Random.Range(min, max+1);
		maxGuessesAllowed --;
		text.text = guess.ToString();
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		}
		
	}
	
	public void GuessHigher() {
		min = guess; 
		NextGuess();
	}
	
	public void GuessLower() {
		max = guess;
		NextGuess();
	}
}
