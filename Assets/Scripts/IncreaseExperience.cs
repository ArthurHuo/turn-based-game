using UnityEngine;
using System.Collections;

public static class IncreaseExperience {

	private static int xpToGive;
	private static LevelUp levelUpScript = new LevelUp();

	public static void AddExperience(){
		xpToGive = GameInformation.PlayerLevel * 100;
		GameInformation.CurrentXP += xpToGive;
		CheckToSeeIfPlayerLeveled ();
		Debug.Log (xpToGive);
	}

	//public static void AddExplorationExperience(){
		//xpToGive = GameInformation.PlayerLevel*
	//}
	public static void AddExperienceFromBattleLose(){
		xpToGive = GameInformation.PlayerLevel * 10;
		GameInformation.CurrentXP += xpToGive;
		CheckToSeeIfPlayerLeveled ();
		Debug.Log (xpToGive);
	}

	private static void CheckToSeeIfPlayerLeveled(){
		if(GameInformation.CurrentXP >= GameInformation.RequiredXP){
			// then the player has leveled up
			levelUpScript.LevelUpCharacter();
			//create level up script
		}
	}



}
