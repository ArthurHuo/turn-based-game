using UnityEngine;
using System.Collections;

public class LoadInformation {

	public static void LoadAllInformation(){
		GameInformation.PlayerName = PlayerPrefs.GetString ("PLAYERNAME");
		GameInformation.PlayerLevel = PlayerPrefs.GetInt ("PLAYERLEVEL");
		GameInformation.Staminia = PlayerPrefs.GetInt ("STAMINIA");
		GameInformation.Endurance = PlayerPrefs.GetInt ("ENDURANCE");
		GameInformation.Intellect = PlayerPrefs.GetInt ("INTELLECT");
		GameInformation.Stength = PlayerPrefs.GetInt ("STRENGTH");
		GameInformation.Agility = PlayerPrefs.GetInt ("AGILITY");
		GameInformation.Resistance = PlayerPrefs.GetInt ("RESISTANCE");
		GameInformation.Gold = PlayerPrefs.GetInt ("GOLD");

	}
}
