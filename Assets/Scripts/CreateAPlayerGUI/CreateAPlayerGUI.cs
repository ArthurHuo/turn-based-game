using UnityEngine;
using System.Collections;

public class CreateAPlayerGUI : MonoBehaviour {

	public enum CreateAPlayerStates{
		CLASSSELECTION, // dispaly all class types
		STATALLOCATION, //allocate state where the players wants too
		FINALSETUP      //add name and misc items gender
	}

	private DisplayCreatedPlayerFunction dispalyFunction = new DisplayCreatedPlayerFunction();
	public static CreateAPlayerStates currentState;

	// Use this for initialization
	void Start () {
		currentState = CreateAPlayerStates.CLASSSELECTION;
		//currentState = CreateAPlayerStates.STATALLOCATION;
	}
	
	// Update is called once per frame
	void Update () {
		switch(currentState){
		case(CreateAPlayerStates.CLASSSELECTION):
			break;
		case(CreateAPlayerStates.STATALLOCATION):
			break;
		case(CreateAPlayerStates.FINALSETUP):
			break;
		}
	}
	void OnGUI(){
		dispalyFunction.DisplayMainItems ();
		if(currentState == CreateAPlayerStates.CLASSSELECTION){
			//Display class select function
			dispalyFunction.DisplayClassSelections();
		}
		if(currentState == CreateAPlayerStates.STATALLOCATION){
			//Display 
			dispalyFunction.DisplayStatAllocation();
		}
		if(currentState == CreateAPlayerStates.FINALSETUP){
			//Display 
			dispalyFunction.DisplayFinalSetup();
		}

	}
}
