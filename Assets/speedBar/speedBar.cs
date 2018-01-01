using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class speedBar : MonoBehaviour {

	Slider slider;

	void Start () {
		slider = GameObject.Find("Slider").GetComponent<Slider>();
	}
	
	float _hp = 0;
	void Update () {
		_hp = move.speed;

		// HPゲージに値を設定
		slider.value = _hp;
	}
}
