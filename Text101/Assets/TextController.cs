using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text; 
	private enum States {cell,sheets_0,lock_0, cell_1, lock_1, corridor_0};
	private States myState;
	
	private bool hasWeapon = true; 
	
	void Example () {
		if (hasWeapon) {
			//Do this
		} else {
			//Do this
		}
	}
	
	
	// Use this for initialization
	void Start () {
		myState = States.cell;
		text.text="Hello World! Press 'space' to start your adventure";
	}
	
	// Update is called once per frame
	void Update () {
	print (myState);
		if 		(myState == States.cell) 		{cell ();}
		else if (myState == States.sheets_0) 	{sheets_0();}
		else if (myState == States.lock_0) 		{lock_0();}
		else if (myState == States.lock_1) 		{lock_1();}
		else if (myState == States.corridor_0) 	{corridor_0();}
	}
	
	void cell() 
	{
		
		text.text = "You are in a prison cell, and you want to escape. There are" +
					" some dirty sheets on the bed, a mirror on the wall, and the door " +
					" is locked from the outside\n\n" + 
					"Press S to view Sheets and L to view Lock";
							
		if 		(Input.GetKeyDown (KeyCode.S)) 	{myState = States.sheets_0;} 
		else if (Input.GetKeyDown (KeyCode.L)) 	{myState = States.lock_0;} 	
	}
	
	void sheets_0 () 
	{
		text.text = "You can't believe you sleep in these things. Surely it's " + 
					"time somebody changed them. The pleasures of prison life " +
					"I guess!\n\n" +
					"Press R to return to roaming your cell";
		if (Input.GetKey(KeyCode.R)) 			{myState = States.cell;} 
	}
	
	void lock_0() 
	{
		text.text = "You look at the lock and notice that it's quite weak and that you could possibly pry it open by pulling on it very hard" +
					"\n\n Would you like to try or go back to roaming your cell? (P/R)"; 
		if 		(Input.GetKey(KeyCode.R)) 		{myState = States.cell;} 
		else if (Input.GetKey(KeyCode.P)) 		{myState = States.lock_1;}
		print (myState);
				
	}
	
	void lock_1 () 
	{
		text.text = "You succeed in prying open the lock and it fell to the ground with a loud 'THUD' \n\n" +
					"Would you like to go back to the cell or go through the door? (C/D)"; 
		print (Input.GetKey(KeyCode.D));			
		if 		(Input.GetKey(KeyCode.C)) 			{myState = States.cell;}
		else if (Input.GetKey(KeyCode.D)) 			{myState = States.corridor_0;} 	 			 
	}
	
	void corridor_0() 
	{
		text.text = "You got out! Queue iron maiden clansman!" +
					"\n\nOut of the room at least, for now you're in a corridor!"; 
	}
}
