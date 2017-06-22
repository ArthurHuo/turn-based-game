using UnityEngine;
using System.Collections;

[System.Serializable]
public class BasePotion : BaseStatItem {

	public enum PotionTypes{
		HEALTH,
		ENERGY,
		STRENGTH,
		INTELLECT,
		VITALITY,
		ENDURANCE,
		SPEED
	}
	private PotionTypes potionType;
	private int spellEffectID;

	public PotionTypes PotionType{ get; set;}
	public int SpellEffectID{ get; set;}
}
