using UnityEngine;
using System.Collections;

public class BaseDwarfRace : BaseCharacterRace {

	public BaseDwarfRace(){
		new BaseCharacterRace ();
		RaceName = "Dwarf";
		RaceDescription = "Is a Dwarf";
		HasIntellectBonus = true;
		HasStrengthBonus = true;
		HasMasteryBonus = true;
	}
}
