using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class attack : MonoBehaviour {

	private Text targetText;

	void Start () {

	}

	void Update () {
		this.targetText = this.GetComponent<Text>(); 
		if(move.attackFlag == true) this.targetText.text = "攻撃不可";
		else this.targetText.text = "攻撃可能";
	}
}
