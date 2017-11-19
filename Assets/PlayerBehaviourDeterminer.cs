using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerBehaviourDeterminer : MonoBehaviour
{
	private String[] behavioursArray = 
		{"Headphones", "Pocket Knives", "Katana", "Glasses"/*, "Textbook", "Magazine"*/};

	public GameObject[] accesories;
	
	private String personsBehaviour;
	// Use this for initialization
	void Start ()
	{
		/*int randomIndex = UnityEngine.Random.Range(0, behavioursArray.Length + 1);
		personsBehaviour = randomIndex == behavioursArray.Length ? "Nothing" : behavioursArray[randomIndex];*/

		for (int i = 0; i < accesories.Length; i++) accesories[i].active = UnityEngine.Random.Range(0, 4) == 0;
		
		/*switch (personsBehaviour)
		{
				case "Headphones":
					accesories[0].active = true;
					accesories[1].active = false;
					accesories[2].active = false;
					accesories[3].active = false;
					//accesories[4].active = false;
					//accesories[5].active = false;
					break;
				case "Pocket Knives":
					accesories[0].active = false;
					accesories[1].active = true;
					accesories[2].active = false;
					accesories[3].active = false;
					//accesories[4].active = false;
					//accesories[5].active = false;
					break;
				case "Katana":
					accesories[0].active = false;
					accesories[1].active = false;
					accesories[2].active = true;
					accesories[3].active = false;
					//accesories[4].active = false;
					//accesories[5].active = false;
					break;
				case "Glasses":
					accesories[0].active = false;
					accesories[1].active = false;
					accesories[2].active = false;
					accesories[3].active = true;
					/*accesories[4].active = false;
					accesories[5].active = false; #1#
					break;
				/*case "Textbook":
					accesories[0].active = false;
					accesories[1].active = false;
					accesories[2].active = false;
					accesories[3].active = false;
					accesories[4].active = true;
					accesories[5].active = false;
					break;
				case "Magazine":
					accesories[0].active = false;
					accesories[1].active = false;
					accesories[2].active = false;
					accesories[3].active = false;
					accesories[4].active = false;
					accesories[5].active = true;
					break;#1#
			
		}*/
	}
}
