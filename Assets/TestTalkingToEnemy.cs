using UnityEngine;
using System.Collections;

using RAIN.Core;
using RAIN.Action;

public class TestTalkingToEnemy : MonoBehaviour {

	AIRig tRig;

	public GameObject enemyGameObj;

	// Use this for initialization
	void Start () {
		tRig = enemyGameObj.GetComponentInChildren<AIRig>();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) 
		{
			print ("space key was pressed");
			int enemyHealth = tRig.AI.WorkingMemory.GetItem<int>("enemyHealth");
			enemyHealth--;
			tRig.AI.WorkingMemory.SetItem<int>("enemyHealth", enemyHealth);
		}
	}
}
