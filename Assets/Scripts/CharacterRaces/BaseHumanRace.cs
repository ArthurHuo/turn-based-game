using UnityEngine;
using System.Collections;

public class BaseHumanRace : BaseCharacterRace {

	public BaseHumanRace(){
		new BaseCharacterRace ();
		RaceName = "Human";
		RaceDescription = "Is a Human";
		HasStaminaBonus = true;
		HasStrengthBonus = true;
		HasCharismaBonus = true;
	}
}
