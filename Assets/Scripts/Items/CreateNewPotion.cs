using UnityEngine;
using System.Collections;

public class CreateNewPotion : MonoBehaviour {

	private BasePotion newPotion;
	//string that several names for postion

	// Use this for initialization
	void Start () {
		CreatePotion ();
		Debug.Log (newPotion.ItemName);
		Debug.Log (newPotion.ItemDescription);
		Debug.Log (newPotion.ItemID.ToString());
		Debug.Log (newPotion.PotionType.ToString());
		Debug.Log (newPotion.Staminia.ToString());
		Debug.Log (newPotion.Endurance.ToString());
	}

	private void CreatePotion(){
		newPotion = new BasePotion ();
		newPotion.ItemName = "Potion";
		newPotion.ItemDescription = "This is a potion";
		newPotion.ItemID = Random.Range (1, 101);
		ChoosePotionType ();
	
	}

	private void ChoosePotionType(){
		int randomTemp = Random.Range (0, 7);
		if(randomTemp == 0){
			newPotion.PotionType = BasePotion.PotionTypes.ENDURANCE;
		}else if(randomTemp == 1){
			newPotion.PotionType = BasePotion.PotionTypes.ENERGY;
		}else if(randomTemp == 2){
			newPotion.PotionType = BasePotion.PotionTypes.HEALTH;
		}else if(randomTemp == 3){
			newPotion.PotionType = BasePotion.PotionTypes.INTELLECT;
		}else if(randomTemp == 4){
			newPotion.PotionType = BasePotion.PotionTypes.SPEED;
		}else if(randomTemp == 5){
			newPotion.PotionType = BasePotion.PotionTypes.STRENGTH;
		}else if(randomTemp == 6){
			newPotion.PotionType = BasePotion.PotionTypes.VITALITY;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
