using UnityEngine;
using System.Collections;

public class SaveInformation {

	public static void SaveAllInformation(){
		PlayerPrefs.SetInt ("PLAYERLEVEL", GameInformation.PlayerLevel);
		PlayerPrefs.SetString ("PLAYERNAME",GameInformation.PlayerName);
		PlayerPrefs.SetInt ("STAMINIA", GameInformation.Staminia);
		PlayerPrefs.SetInt ("ENDURANCE", GameInformation.Endurance);
		PlayerPrefs.SetInt ("INTELLECT", GameInformation.Intellect);
		PlayerPrefs.SetInt ("STRENGTH", GameInformation.Stength);
		PlayerPrefs.SetInt ("AGILITY", GameInformation.Agility);
		PlayerPrefs.SetInt ("RESISTANCE", GameInformation.Resistance);
		PlayerPrefs.SetInt ("GOLD", GameInformation.Gold);
		Debug.Log ("SAVED ALL INFORMATION");
	}
}
