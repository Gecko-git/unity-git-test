using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class speed : MonoBehaviour {
	
	private Text targetText;

	void Start () {
		
	}

	void Update () {
		this.targetText = this.GetComponent<Text>(); 
		this.targetText.text = move.speed.ToString();
	}
}
