using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damag : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log (other.name);
		move.hp -= 1;
	}
}
