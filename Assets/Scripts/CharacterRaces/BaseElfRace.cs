using UnityEngine;
using System.Collections;

public class BaseElfRace : BaseCharacterRace {

	public BaseElfRace(){
		new BaseCharacterRace ();
		RaceName = "Elf";
		RaceDescription = "Is a Elf";
		HasStaminaBonus = true;
		HasOverpowerBonus = true;
		HasEnduranceBonus = true;
	}
}
