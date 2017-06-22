using UnityEngine;
using System.Collections;

public class CreateNewCharacter : MonoBehaviour {

	private BasePlayer newPlayer;
	private bool isMageClass;
	private bool isWarriorClass;
	private string playerName = "Enter Name";

	// Use this for initialization
	void Start () {
		newPlayer = new BasePlayer ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		playerName = GUILayout.TextArea (playerName,15);

		isMageClass = GUILayout.Toggle(isMageClass,"Mage Class");
		isWarriorClass = GUILayout.Toggle(isWarriorClass,"Warrior Class");
		if(GUILayout.Button("Create")){
			if(isMageClass){
				newPlayer.PlayerClass = new BaseMageClass();
			}else if(isWarriorClass){
				newPlayer.PlayerClass = new BaseWarriorClass();
			}
			CreateNewPlayer();
			StoreNewPlayerInfo();
			SaveInformation.SaveAllInformation();


		}
		if(GUILayout.Button("Load")){
			Application.LoadLevel("test");
		}
	}
	private void StoreNewPlayerInfo(){
		GameInformation.PlayerName = newPlayer.PlayerName;
		GameInformation.PlayerLevel = newPlayer.PlayerLevel;
		GameInformation.Staminia = newPlayer.Staminia;
		GameInformation.Endurance = newPlayer.Endurance;
		GameInformation.Intellect = newPlayer.Intellect;
		GameInformation.Stength = newPlayer.Strength;
		GameInformation.Agility = newPlayer.Agility;
		GameInformation.Resistance = newPlayer.Resistance;
		GameInformation.Gold = newPlayer.Gold;
	}

	private void CreateNewPlayer(){
		newPlayer.PlayerLevel = 1;
		newPlayer.Staminia = newPlayer.PlayerClass.Staminia;
		newPlayer.Endurance = newPlayer.PlayerClass.Endurance;
		newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
		newPlayer.Strength = newPlayer.PlayerClass.Strength;
		newPlayer.Agility = newPlayer.PlayerClass.Agility;
		newPlayer.Resistance = newPlayer.PlayerClass.Resistance;
		newPlayer.Gold = 10;
		newPlayer.PlayerName = playerName;

		//Debug.Log("Player Name: " + newPlayer.PlayerName);
		//Debug.Log("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
		//Debug.Log("Player Level: " + newPlayer.PlayerLevel);
		//Debug.Log("Player Staminia: " + newPlayer.Staminia);
		//Debug.Log("Player Endurance: " + newPlayer.Endurance);
		//Debug.Log("Player Intellect: " + newPlayer.Intellect);
		//Debug.Log("Player Strength: " + newPlayer.Strength);
	
	}

}
