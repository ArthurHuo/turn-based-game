using UnityEngine;
using System.Collections;

public class BaseGnomeRace : BaseCharacterRace {

	public BaseGnomeRace(){
		new BaseCharacterRace ();
		RaceName = "Gnome";
		RaceDescription = "Is a Gnome";
		HasIntellectBonus = true;
		HasEnduranceBonus = true;
		HasLuckBonus = true;
	}
}
