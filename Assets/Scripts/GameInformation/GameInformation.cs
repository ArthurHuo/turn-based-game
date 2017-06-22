using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad (transform.gameObject);
	}


	public static string PlayerBio{ get; set;}
	public static bool IsMale{ get; set;}
	public static string PlayerName{ get; set;}
	public static int PlayerLevel{ get; set;}
	public static BaseCharacterClass PlayerClass{ get; set;}
	public static int Staminia{ get; set;}
	public static int Endurance{ get; set;}
	public static int Intellect{ get; set;}
	public static int Stength{ get; set;}
	public static int Agility{ get; set;}
	public static int Resistance{ get; set;}
	public static int Gold{ get; set;}
	public static int CurrentXP{ get; set;}
	public static int RequiredXP{get;set;}


}
