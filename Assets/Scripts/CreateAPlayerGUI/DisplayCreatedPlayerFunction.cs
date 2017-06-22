using UnityEngine;
using System.Collections;

public class DisplayCreatedPlayerFunction {

	private StatAllocationModule statAllocationModule = new StatAllocationModule();

	private int classSelection;
	private string[] classSelectionNames = new string[]{"Mage","Warrior","Archer","Rogue","Warlock","Paladin"};
	private string playerFirstName = "Enter First Name"; //name
	private string playerLastName = "Enter Last Name";
	private string playerBio = "Enter Player Bio"; //bio
	private bool isMale = true; //gender selection
	private int genderSelection;
	private string[] genderTypes = new string[2]{"Male","Female"};

	public void DisplayClassSelections(){
		//A list of toggle buttons and each button will be a different class
		//selection grid
		classSelection = GUI.SelectionGrid (new Rect(50,50,250,300),classSelection,classSelectionNames,3);
		GUI.Label (new Rect(450,50,300,300),FindClassDescription(classSelection));
		GUI.Label (new Rect(450,100,300,300),FindClassStatValues(classSelection));

	}

	private string FindClassDescription(int classSelection){
		if(classSelection == 0){
			BaseCharacterClass tempClass = new BaseMageClass();
			return tempClass.CharacterClassDescription;
		}else if(classSelection == 1){
			BaseCharacterClass tempClass = new BaseWarriorClass();
			return tempClass.CharacterClassDescription;
		}
		return "NO CLASS FOUND!";
	}

	private string FindClassStatValues(int classSelection){
		if(classSelection == 0){
			BaseCharacterClass tempClass = new BaseMageClass();
			string tempStats = "Stamina " + tempClass.Staminia + "\n" + "Endurance" + tempClass.Endurance;
			return tempStats;
		}else if(classSelection == 1){
			BaseCharacterClass tempClass = new BaseWarriorClass();
			string tempStats = "Stamina " + tempClass.Staminia + "\n" + "Endurance" + tempClass.Endurance;
			return tempStats;
		}

		return "NO STATS FOUND!";
	}

	public void DisplayStatAllocation(){
		//a list of stats with plus and minus buttons to add stats
		//logic to make sure the player cannot add more than stats given
		statAllocationModule.DisplayStatAllocationModule ();
	}

	public void DisplayFinalSetup(){
		//name
		playerFirstName = GUI.TextArea (new Rect(20,10,100,35),playerFirstName,25);
		playerLastName = GUI.TextArea (new Rect(20,55,100,35),playerLastName,25);
		//gender
		//isMale = GUI.Toggle (new Rect(0,0,0,0));
		genderSelection = GUI.SelectionGrid (new Rect(200,10,100,70),genderSelection,genderTypes,1);
		//add a description to your character, a short bio
		playerBio = GUI.TextArea (new Rect(20,90,250,200),playerBio,250);

	}

	private void ChooseClass(int classSelection){
		if(classSelection == 0){
			GameInformation.PlayerClass = new BaseMageClass();
		}else if(classSelection == 1){
			GameInformation.PlayerClass = new BaseWarriorClass();
		}
	}

	public void DisplayMainItems(){
		Transform player = GameObject.FindGameObjectWithTag("Player").transform;

		GUI.Label (new Rect(Screen.width/2,20,250,250),"CREATE NEW PLAYER");

		if(GUI.Button(new Rect(320,350,50,50),"<<<")){
			//turn transform togged as player to the left
			player.Rotate(Vector3.up*10);
		}
		if(GUI.Button(new Rect(470,350,50,50),">>>")){
			//turn transform togged as player to the right
			player.Rotate(Vector3.down*10);
		}

		if(CreateAPlayerGUI.currentState != CreateAPlayerGUI.CreateAPlayerStates.FINALSETUP){
			if(GUI.Button(new Rect(600,350,50,50),"Next")){
				if(CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.CLASSSELECTION){
					ChooseClass (classSelection);
					CreateAPlayerGUI.currentState = CreateAPlayerGUI.CreateAPlayerStates.STATALLOCATION;
				}else if(CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.STATALLOCATION){
					//for(int i = 0; i < statAllocationModule.pointsToAllocate.Length;i++){
					//}
					GameInformation.Staminia = statAllocationModule.pointsToAllocate[0];
					GameInformation.Endurance = statAllocationModule.pointsToAllocate[1];
					GameInformation.Intellect = statAllocationModule.pointsToAllocate[2];
					GameInformation.Stength = statAllocationModule.pointsToAllocate[3];
					GameInformation.Agility = statAllocationModule.pointsToAllocate[4];
					GameInformation.Resistance = statAllocationModule.pointsToAllocate[5];
					CreateAPlayerGUI.currentState = CreateAPlayerGUI.CreateAPlayerStates.FINALSETUP;
				}
				
			}
		}else if(CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.FINALSETUP){
			if(GUI.Button(new Rect(600,350,50,50),"Finish")){
				//Finall save
				GameInformation.PlayerName = playerFirstName +" "+playerLastName;
				GameInformation.PlayerBio = playerBio;
				if(genderSelection == 0){
					GameInformation.IsMale = true;
				}else if(genderSelection == 1){
					GameInformation.IsMale = false;
				}

				SaveInformation.SaveAllInformation();
			}
		}


		if(CreateAPlayerGUI.currentState != CreateAPlayerGUI.CreateAPlayerStates.CLASSSELECTION){
			if(GUI.Button(new Rect(550,350,50,50),"Back")){
				if(CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.STATALLOCATION){
					statAllocationModule.didRunOnce = false;
					GameInformation.PlayerClass = null;
					CreateAPlayerGUI.currentState = CreateAPlayerGUI.CreateAPlayerStates.CLASSSELECTION;
				}else if(CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.FINALSETUP){
					CreateAPlayerGUI.currentState = CreateAPlayerGUI.CreateAPlayerStates.STATALLOCATION;
				}
				
			}
		}





	}

}
