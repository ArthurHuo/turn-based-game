using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharacterClass {

	public BaseMageClass(){
		CharacterClassName = "Mage";
		CharacterClassDescription = "A wise wizard, can cast spells!";
		Staminia = 12;
		Endurance = 14;
		Strength = 10;
		Intellect = 15;
		Agility = 10;
		Resistance = 15;
	}

}
