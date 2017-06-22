using UnityEngine;
using System.Collections;

public class BasePlayer {

	private string playerName;
	private int playerLevel;
	private BaseCharacterClass playerClass;

	private int staminia;     //health modifier
	private int endurance;	  //energy modifier
	private int intellect;    //magical damage modifier
	private int strength;     //physical damage modifier
	private int agility;      //haste and crit modifier
	private int resistance;   //all damage reduction

	private int gold; //in game currency

	private int currentXP;
	private int requiredXP;

	private int statPointsToAllocate;

	public string PlayerName{ get; set;}
	public int PlayerLevel{ get; set;}
	public BaseCharacterClass PlayerClass{ get; set;}
	public int Staminia { get; set;}
	public int Endurance { get; set;}
	public int Intellect { get; set;}
	public int Strength { get; set;}
	public int CurrentXP{ get; set;}
	public int RequiredXP{ get; set;}

	public int Agility{ get; set;}
	public int Resistance{ get; set;}
	public int Gold{ get; set;}
	public int StatPointsToAllocate{ get; set;}

}
