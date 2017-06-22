﻿using UnityEngine;
using System.Collections;

public class TurnBasedCombatStateMachine : MonoBehaviour {

	private bool hasAddedXP;

	public enum BattleStates{
		START,
		PLAYERCHOICE,
		//PLAYERANIM
		ENEMYCHOICE,
		LOSE,
		WIN
	}
	private BattleStates currentState;


	// Use this for initialization
	void Start () {
		currentState = BattleStates.START;
		hasAddedXP = false;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (currentState);
		switch(currentState){
		case (BattleStates.START):
			//SETUP BATTLE FUNCTION
			break;
		case(BattleStates.PLAYERCHOICE):
			break;
		case(BattleStates.ENEMYCHOICE):
			break;
		case(BattleStates.LOSE):
			break;
		case(BattleStates.WIN):
			break;
		}
	}
	void OnGUI(){
		if(GUILayout.Button("NEXT STATE")){
			if(currentState == BattleStates.START){
				currentState = BattleStates.PLAYERCHOICE;
			}else if(currentState == BattleStates.PLAYERCHOICE){
				currentState = BattleStates.ENEMYCHOICE;
			}else if(currentState == BattleStates.ENEMYCHOICE){
				currentState = BattleStates.LOSE;
			}else if(currentState == BattleStates.LOSE){
				currentState = BattleStates.WIN;
			}else if(currentState == BattleStates.WIN){
				if(!hasAddedXP){
					IncreaseExperience.AddExperience();
					hasAddedXP = true;
				}

				currentState = BattleStates.START;
			}
		}

	}
}
