﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseWeapon : BaseStatItem {

	public enum WeaponTypes{
		SWORD,
		STAFF,
		DAGGER,
		BOW,
		SHIELD,
		POLEARM
	}
	private WeaponTypes weaponType;
	private int spellEffectID;
	

	public WeaponTypes WeaponType{ get; set;}
	public int SpellEffectID{ get; set;}
}
