using UnityEngine;
using System.Collections;

public class BaseCharacterRace {

	private string raceName = "Need a Name";
	private string raceDescription = "Need a Description";
	private bool hasStrengthBonus = false;
	private bool hasIntellectBonus = false;
	private bool hasStaminaBonus = false;
	private bool hasEnduranceBonus = false;
	private bool hasOverpowerBonus = false;
	private bool hasLuckBonus = false;
	private bool hasMasteryBonus = false;
	private bool hasCharismaBonus = false;

	public BaseCharacterRace(){
		raceName = "Need a Name";
		raceDescription = "Need a Description";
		hasStrengthBonus = false;
		hasIntellectBonus = false;
		hasStaminaBonus = false;
		hasEnduranceBonus = false;
		hasOverpowerBonus = false;
		hasLuckBonus = false;
		hasMasteryBonus = false;
		hasCharismaBonus = false;

	}

	public string RaceName{ get; set;}
	public string RaceDescription{ get; set;}
	public bool HasStrengthBonus{ get; set;}
	public bool HasIntellectBonus{ get; set;}
	public bool HasStaminaBonus{ get; set;}
	public bool HasEnduranceBonus{ get; set;}
	public bool HasOverpowerBonus{ get; set;}
	public bool HasLuckBonus{ get; set;}
	public bool HasMasteryBonus{ get; set;}
	public bool HasCharismaBonus{ get; set;}

}
